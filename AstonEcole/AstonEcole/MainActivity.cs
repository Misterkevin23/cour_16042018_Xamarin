using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace AstonEcole
{
    [Activity(Label = "AstonEcole", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
  
            var list = FindViewById<ListView>(Resource.Id.listView1);

            //ArrayAdapter<Instructor>  adapter = new ArrayAdapter<Instructor>(this,Android.Resource.Layout.SimpleListItem1, InstructorData.Instructors);

            list.Adapter = new InstructorAdapter(InstructorData.Instructors);

            list.FastScrollEnabled = true;

            list.ItemClick += OnItemClick;

            void OnItemClick(object sender, AdapterView.ItemClickEventArgs e)
            {
                Instructor target = InstructorData.Instructors[e.Position];

                var dialog = new AlertDialog.Builder(this);           

                dialog.SetMessage(target.Name );
                dialog.SetNeutralButton("Return",
                  delegate
                  {
 
                  });
                dialog.Show();

            }
        }
    }
}

