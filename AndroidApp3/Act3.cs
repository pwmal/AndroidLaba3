using Android.Content;

namespace AndroidApp3
{
    [Activity(Label = "@string/act3")]
    public class Act3 : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Act3);

            EditText et1 = FindViewById<EditText>(Resource.Id.Act3et1);

            Button bt1 = FindViewById<Button>(Resource.Id.Act3bt1);

            List<groupmates> groupmates = App.Db.GetAll();

            bt1.Click += delegate
            {
                if (et1.Text != "" && et1.Text != " ")
                {
                    App.Db.Save(new groupmates { id = 1 + groupmates.Count, name = et1.Text, time = DateTime.Now.ToString()});
                    et1.Text = "";

                    Intent intent = new Intent(this, typeof(MainActivity));

                    StartActivity(intent);
                }
            };
            
        }
    }
}
