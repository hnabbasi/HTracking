namespace HTracking.Models
{
    public class BaseForm
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }

    public class SiteForm : BaseForm
    {
        public string SiteName
        {
            get;
            set;
        }
    }

    public class InventoryForm : BaseForm
    {
        public string ChemicalName
        {
            get;
            set;
        }
    }
}
