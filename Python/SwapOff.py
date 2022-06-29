# This script will check Swap memory on linux devices, if the swap mem is too full -
# it will offload the memory onto the normal memory if there is enough space on the physical memory

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

print(f"""

Ram installed on the device: {RamInstalled}
Ram being used on the device: {RamInUse}

Initial memory set: {InitialMem}
Initial swap memory allocated for test: {SwapUsedInitial}

""")
