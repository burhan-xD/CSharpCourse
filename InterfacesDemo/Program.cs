// istanbulKodluyor FullStack .NET Eğitimi - Grup 1B
// Arrays
// bunu yazan kişi öğrenme aşamasında ve kısıtlı ingilizce bilgisi olduğunda dolayı bazen türkçe, bazen ingilizce terimler, açıklamalar kullanmıştır.
// Author: burhan-xD

IWorker[] workers = new IWorker[3]
{
    new Manager(),
    new Worker(),
    new Robot(),
};

foreach (var worker in workers)
{
    worker.Work();
}

IEat[] eats = new IEat[2]
{
    new Manager(),
    new Worker(),
};


interface IWorker
{
    void Work();
}

interface IEat
{
    void Eat();
}

interface ISalary
{
    void GetSalary();
}

class Manager : IWorker, ISalary, IEat
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

class Worker : IWorker, ISalary, IEat
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

class Robot : IWorker
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}