ɱ���߳� - Abort
Thread���Abort�����������õ�ɱ��һ���̡߳�������ע�⣬�ڵ���Abort����ǰһ��Ҫ�ж��߳��Ƿ񻹼����
if ( mythread.IsAlive )
{
����mythread.Abort();
}

��ͣ�߳� - Sleep
Thread.Sleep�������ڽ�һ���߳���ͣһ��ʱ�䣬�������£�
Thread.Sleep(int);

�����߳� - Suspend
Thread���Suspend�������Թ����̡߳�
if (mythread.ThreadState = ThreadState.Running )
{
����mythread.Suspend();
}

�ָ���������߳� - Resume
����Resume�������Իָ�һ����������̡߳�
if (mythread.ThreadState = ThreadState.Suspended )
{
����mythread.Resume();
}

Sleep �Ǿ�̬��������Suspend ��ʵ��������Suspend�������������̣߳�����һ�εĵȴ�ʱ�䡣
Sleep ��ֻ����ͣ��ǰʱ�䣬��Suspend���Թ��𣬱���̡߳���������̵߳Ļָ���Ҳ��Ҫ��Resume������ִ�С�