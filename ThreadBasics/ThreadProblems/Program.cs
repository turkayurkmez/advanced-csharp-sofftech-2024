// See https://aka.ms/new-console-template for more information

using ThreadProblems;

void withThreads(){
    PrintComponent printComponent = new PrintComponent();
    Thread[] threads = new Thread[5];

    for (int i = 0; threads.Length > i; i++) {
        threads[i] = new Thread(new ThreadStart(printComponent.PrintNumbers));
        threads[i].Start();
    }
}

void withTasks()
{
    PrintComponent printComponent = new PrintComponent();
    Task[] tasks = new Task[5];
    for (int i = 0; i < tasks.Length; i++)
    {
        tasks[i] = new Task(() => printComponent.PrintNumbers());
        tasks[i].Start();
        tasks[i].Wait();
    }
}

//withThreads();
withTasks();
