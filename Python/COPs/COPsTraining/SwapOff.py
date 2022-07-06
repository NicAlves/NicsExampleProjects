print("please enter a random amount of total swap mem in mb")
InitialMem = int(input())

if InitialMem <= 1000:
    print("Needs to be higher than 1000mb")
    quit()

print("Please enter a random ammount that the swap mem is being used.")
SwapUsedInitial = int(input())

print("please enter the amount of ram the system has installed in MB")
RamInstalled = int(input())
print("please enter the amount of ram being used by the system before the mem swap in MB")
RamInUse = int(input())

print("please enter the command you want to use:")
SwapOff = input()
if SwapOff == "swapoff":
    print("swap mem has been cleared.")
    MemAfterSwap = SwapUsedInitial + RamInUse
    SwapMemAfterSwap = SwapUsedInitial - SwapUsedInitial
else:
    print("Command not recognised! Please try again.")
    quit()

print(f"""
Information provided yielded the following results:

Ram installed on the device: {RamInstalled}
Ram being used on the device: {RamInUse}
Initial memory set: {InitialMem}
Initial swap memory allocated for test: [ Nothing Yet ]

""")


