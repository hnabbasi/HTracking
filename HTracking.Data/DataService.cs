using System.Collections.Generic;
using HTracking.Models;

namespace HTracking.Data
{
    public interface IDataService 
    {
        IList<BaseForm> GetForms();
        void SubmitForm(BaseForm form);
    }

    public class DataService : IDataService
    {
        IList<BaseForm> _forms;

        public DataService()
        {
            _forms = new List<BaseForm>
            {
                new SiteForm { Id = 1, Name = "Site Information Form", SiteName = "NW Site" },
                new SiteForm { Id = 2, Name = "Site Information Form", SiteName = "SW Site" },
                new SiteForm { Id = 3, Name = "Site Information Form", SiteName = "NE Site" },
                new InventoryForm { Id = 4, Name = "Chemicals Inventory Form", ChemicalName = "Chemical 101" },
                new InventoryForm { Id = 5, Name = "Chemicals Inventory Form", ChemicalName = "Chemical 201" },
                new InventoryForm { Id = 6, Name = "Chemicals Inventory Form", ChemicalName = "Chemical 501" },
            };
        }

        public IList<BaseForm> GetForms() => _forms;

        public void SubmitForm(BaseForm form)
        {
            _forms.Add(form);
        }
    }
}
