using Android.Content;

namespace AndroidApp3
{
    [Activity(Label = "@string/act2")]
    public class Act2 : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Act2);

            List<groupmates> groupmates = App.Db.GetAll();

            TextView column_id = FindViewById<TextView>(Resource.Id.column_id);

            TextView column_name = FindViewById<TextView>(Resource.Id.column_name);

            TextView column_time = FindViewById<TextView>(Resource.Id.column_time);

            Button bt1 = FindViewById<Button>(Resource.Id.Act2bt1);

            column_id.Text += Environment.NewLine;

            column_name.Text += Environment.NewLine;

            column_time.Text += Environment.NewLine;

            for (int i = 0; i < groupmates.Count; i++)
            {
                column_id.Text += $"{groupmates[i].id.ToString() + Environment.NewLine}";

                column_name.Text += $"{groupmates[i].name.ToString() + Environment.NewLine}";

                column_time.Text += $"{groupmates[i].time.ToString() + Environment.NewLine}";
            }

            bt1.Click += delegate
            {
                for(int i = 0;i < groupmates.Count;i++)
                {
                    App.Db.Delete(groupmates[i]);
                }

                Intent intent = new Intent(this, typeof(MainActivity));

                StartActivity(intent);
            };
        }
    }
}
