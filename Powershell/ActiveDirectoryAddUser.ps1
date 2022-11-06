# This script has been made to automate the user creation process. Work In Progress.
# I need to add a "do" loop so the questions can loop if the user does not enter a valid answer

# This just looks cool
Write-Host "===============COPs============COPs================="
Write-Host 
Write-Host "  User creation script! Enter the data as required"
Write-Host
Write-Host "===================================================="
Write-Host

# Import AD module
Import-Module ActiveDirectory
# Grabbing the users credentials to allow for the script to have perms.
# $Cred = Get-Credential -Message "Please enter your $($env:USERDOMAIN.ToLower()) credentials" -UserName $Username

# Gather the details about the new AD user
$FirstName = Read-Host "What is the users first name / given name? "
Write-Host
$Surname = Read-Host "What is the users surname? "
$FullName = $FirstName + " " + $Surname
Write-Host
$PrincipalName = Read-Host "What will the username be? i.e. nalves"
Write-Host
$AccountPwd = Read-Host "Please enter a temp password for the user"
Write-Host
$UserEnabledQuestion = Read-Host "Do you want the user to be disabled when the creation is complete? y/n ".ToLower()
Write-Host
$JobTitle = Read-Host "Please type the role of the user using these options to get the required set of groups: 'Junior Engineer', 'Engineer', 'Senior Engineer'".ToLower()

$Domain = 'il2management.dev'

# Just to check if the users account will need to be enabled or not, using this Var  in the New-ADUser command.
if ($UserEnabledQuestion -eq "y"){
	$UserEnabled = 0
} 
else{
	$UserEnabled = 1
}

# Create the new AD  within users
New-ADUser `
    -Name "$FullName" `
    -GivenName $FirstName `
    -Surname $Surname `
    -UserPrincipalName "su$PrincipalName@$Domain" `
    -SamAccountName "su$PrincipalName" `
    -DisplayName "$FullName" `
    -AccountPassword (ConvertTo-SecureString $AccountPwd -AsPlainText -Force) `
    -Path "" `
    # Add OU in path ^^
    -ChangePasswordAtLogon 0 `
    -Enabled $UserEnabled `

$UserLogonNamePre2000 = 'su' + $PrincipalName

if ($JobTitle -eq "junior engineer"){
    Add-ADGroupMember -Identity "Testing7" -Members $UserLogonNamePre2000
}

Exit