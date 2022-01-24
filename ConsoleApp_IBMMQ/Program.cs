// See https://aka.ms/new-console-template for more information

using IBM.WMQ;
using ibmmq_samples;

Thread thread1 = new Thread(SimpleSubscriber.Sub);
thread1.Start();

Thread thread2 = new Thread(SimplePublisher.Pub);
thread2.Start();


Thread.Sleep(10000);
Thread thread10 = new Thread(SimpleSubscriber.Sub);
thread10.Start();
