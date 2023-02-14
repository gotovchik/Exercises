
public class UI
{
    View view;
    public UI(View view)
    {
        this.view = view;
    }

    public void Start()
    {
        bool flag = true;
        while(flag)
        {
            view.Show("Является ли число квадратом второго числа? \n" +
                  "Введите первое число:");
            Number a = new(Convert.ToInt32(Console.ReadLine()));
            view.Show("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (!a.IsGood(b))
            {
                view.Show("Нет, не является!");
            }
            else
            {
                view.Show("Да, является!");
            }
            view.Show("Продолжаем? Y/N");
            if (Console.ReadKey(true).KeyChar == 'n') flag = false;
        }
        

    }
}