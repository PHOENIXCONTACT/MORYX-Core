HeartOfGold {#runtime-heartOfGold}
========

# Description
The platform is called the Runtime whereas the executable is called the HeartOfGold. The HeartOfGold.exe provides the applications entry point and is responsible for executing the boot sequence explained below. After loading the RunMode and level 1 composition it will pass control to the RunMode.

# Available arguments

| Command | Parameter | Description |
|---------|----------|-------------|
| -c | ConfigDirectory | Sets the directory used by the ConfigManager to read and write module configurations. |
| -d | - | Enforces the developer mode aka RuntimeEmulator. This is the default used by the Windows console. |
| -r | RunMode | Specify the RunMode to use. |
| -dbUpdate | - | 	Update all databases with outdated versions. Only Runtime >= 2.6 |
| -h | - | Print help page |

Further arguments might be defined by the different RunModes.

# Unhandled exception handling

Even with all possible effort it is not possible to make an application immune to unhandled exceptions. Throwing exceptions in a new thread will almost always kill the application. For later debugging of the error the exception causing the system crash is written to a CrashLog in the CrashLogs subdirectory of the runtime directory. The time of occurrence of the exception is encoded in the file name. A possible output would be CrashLog_14-05-12_03-39-59.txt

````
Unhandled exception occurred: 
System.Exception: Unhandled exception for Bjoern
   bei DummyService.DummyWithCompPlugin.<OnStart>b__0(Object state) in d:\MarvinRepo\SvcRuntime\DummyService\Plugin\DummyWithComp.cs:Zeile 75.
   bei System.Threading.QueueUserWorkItemCallback.WaitCallback_Context(Object state)
   bei System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   bei System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   bei System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()
   bei System.Threading.ThreadPoolWorkQueue.Dispatch()
   bei System.Threading._ThreadPoolWaitCallback.PerformWaitCallback()
````