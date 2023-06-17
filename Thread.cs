杀死线程 - Abort
Thread类的Abort方法用于永久地杀死一个线程。但是请注意，在调用Abort方法前一定要判断线程是否还激活，：
if ( mythread.IsAlive )
{
　　mythread.Abort();
}

暂停线程 - Sleep
Thread.Sleep方法用于将一个线程暂停一段时间，代码如下：
Thread.Sleep(int);

挂起线程 - Suspend
Thread类的Suspend方法可以挂起线程。
if (mythread.ThreadState = ThreadState.Running )
{
　　mythread.Suspend();
}

恢复被挂起的线程 - Resume
调用Resume方法可以恢复一个被挂起的线程。
if (mythread.ThreadState = ThreadState.Suspended )
{
　　mythread.Resume();
}

Sleep 是静态方法，而Suspend 是实例方法。Suspend不会立即挂起线程，会有一段的等待时间。
Sleep 是只能暂停当前时间，而Suspend可以挂起，别的线程。被挂起的线程的恢复，也需要用Resume方法来执行。