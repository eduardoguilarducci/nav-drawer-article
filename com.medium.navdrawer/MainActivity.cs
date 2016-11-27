using Android.App;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Widget;

namespace com.medium.navdrawer
{
	[Activity(Label = "Navigation Drawer", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : AppCompatActivity
	{

		DrawerLayout drawerLayout;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

			var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
			SetSupportActionBar(toolbar);


			drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

			var drawerToggle = new ActionBarDrawerToggle(this, drawerLayout, toolbar, Resource.String.open_drawer, Resource.String.close_drawer);
			drawerLayout.AddDrawerListener(drawerToggle);
			drawerToggle.SyncState();


			var navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
			navigationView.NavigationItemSelected += NavigationView_NavigationItemSelected;


		}
		void NavigationView_NavigationItemSelected(object sender, NavigationView.NavigationItemSelectedEventArgs e)
		{
			switch (e.MenuItem.ItemId)
			{
				case (Resource.Id.nav_home):
					Toast.MakeText(this, "selecionando menu Home", ToastLength.Short).Show();
					break;
				case (Resource.Id.nav_xamarin):
					Toast.MakeText(this, "selecionando menu Xamarin", ToastLength.Short).Show();
					break;
				case (Resource.Id.nav_microsoft):
					Toast.MakeText(this, "selecionando menu Microsoft", ToastLength.Short).Show();
					break;
				case (Resource.Id.nav_medium):
					Toast.MakeText(this, "selecionando menu Medium", ToastLength.Short).Show();
					break;
				case (Resource.Id.nav_menu1):
					Toast.MakeText(this, "selecionando menu Menu 1", ToastLength.Short).Show();
					break;
				case (Resource.Id.nav_menu2):
					Toast.MakeText(this, "selecionando menu Menu 2", ToastLength.Short).Show();
					break;
				case (Resource.Id.nav_menu3):
					Toast.MakeText(this, "selecionando menu Menu 3", ToastLength.Short).Show();
					break;


			}
		}

	}
}

