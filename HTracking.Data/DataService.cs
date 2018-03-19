using System.Collections.Generic;
using HTracking.Models;

namespace HTracking.Data
{
    public interface IDataService 
    {
        IList<T> GetForms<T>() where T : BaseForm;
        void SubmitForm<T>(T form) where T : BaseForm;
    }

    public class DataService : IDataService
    {
        public IList<SiteForm> SiteForms { get; private set; }
        public IList<InventoryForm> InventoryForms { get; private set; }

        public DataService()
        {
            SiteForms = new List<SiteForm>
            {
                new SiteForm { Id = 1, Name = "Site Information Form", SiteName = "NW Site" },
                new SiteForm { Id = 2, Name = "Site Information Form", SiteName = "SW Site" },
                new SiteForm { Id = 3, Name = "Site Information Form", SiteName = "NE Site" }
            };

            InventoryForms = new List<InventoryForm>
            {
                new InventoryForm { Id = 4, Name = "Chemicals Inventory Form", ChemicalName = "Chemical 101" },
                new InventoryForm { Id = 5, Name = "Chemicals Inventory Form", ChemicalName = "Chemical 201" },
                new InventoryForm { Id = 6, Name = "Chemicals Inventory Form", ChemicalName = "Chemical 501" }
            };
        }

        public IList<T> GetForms<T>() where T : BaseForm
        {
            return (List<T>) T.GetType() is SiteForm ? SiteForms : InventoryForms;
        }

        public void SubmitForm<T>(T form) where T : BaseForm
        {
            if (form.Id < 1)
                form.Id = Forms.Count + 1;
            Forms.Add(form);
        }
    }
}
