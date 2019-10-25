using System; // add array

// change main parent as
public class MainActivity : ListActivity

// place this array
static readonly string[] countries = new String[] { a,b,c};

protected override void OnCreate (Bundle bundle)
{
// here dony use view becouse list genarated through adapter
    base.OnCreate (bundle);

    ListAdapter = new ArrayAdapter<string> (this, Resource.Layout.list_item, countries); // if you derided by array then replace Android.Resource.Layout.SimpleListItem1

    ListView.TextFilterEnabled = true;

    ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
    {
        Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short).Show();
    };
    
    
    
    // if you dont use the array then you can use a XML file that placed in string xml
    
    <?xml version="1.0" encoding="utf-8"?>
<resources>
  <string name="app_name">HelloListView</string>
  <string-array name="countries_array">
    <item>Bahrain</item>
    <item>Bangladesh</item>
    <item>Barbados</item>
    <item>Belarus</item>
    <item>Belgium</item>
    <item>Belize</item>
    <item>Benin</item>
  </string-array>
</resources>

// and then retrive via array call
string[] countries = Resources.GetStringArray (Resource.Array.countries_array);
ListAdapter = new ArrayAdapter<string> (this, Resource.Layout.list_item, countries);
}
