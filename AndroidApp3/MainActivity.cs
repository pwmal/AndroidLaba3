using Android.Content;

namespace AndroidApp3
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            Button MainB1 = FindViewById<Button>(Resource.Id.MainB1);

            Button MainB2 = FindViewById<Button>(Resource.Id.MainB2);

            Button MainB3 = FindViewById<Button>(Resource.Id.MainB3);

            MainB3.Text = $"Изменить{Environment.NewLine}последнее{Environment.NewLine}ФИО";

            MainB1.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act2));

                StartActivity(intent);
            };

            MainB2.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act3));

                StartActivity(intent);
            };

            MainB3.Click += delegate
            {
                List<groupmates> groupmates = App.Db.GetAll();

                groupmates a = groupmates[groupmates.Count - 1];
                a.name = "Иванов Иван Иванович";

                App.Db.Update(a);
            };
        }
    }
}