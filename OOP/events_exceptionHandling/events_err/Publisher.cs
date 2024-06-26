namespace events_err;
/*
Events, delegelerin özel bir türüdür ve olayların meydana geldiğini bildirmek için 
kullanılır. Genellikle UI ve GUI uygulamalarında yaygın olarak kullanılır.
Eventler, sadece bildirilen sınıf içinde çağrılabilir.
*/
public class Publisher
{
    public delegate void Notify();
    public event Notify OnNotify;

    public void RaiseEvent(){
        if (OnNotify != null)
        {
            OnNotify();
        }
    }

}

public class Subscriber
{
    public void Subscribe(Publisher publisher)
    {
        publisher.OnNotify += HandleEvent;
    }
    private void HandleEvent()
    {
        Console.WriteLine("Event received");
    }
}
