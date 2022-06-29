PERMS = ""

print("What is the CID of the device? ")
CID = input()

if "i2" in CID:
    PERMS = "assured"
elif "i3" in CID:
    PERMS = "elevated"

print("username:")
UserName = input()

if "su" not in UserName:
    print("Invalid username. Please try again.")
    quit()

print(f"""
User Name: {UserName}

CID: {CID}

Secure Level: {PERMS}

A ticket will now show up in JIRA!
Make any addition changes there.

""")
