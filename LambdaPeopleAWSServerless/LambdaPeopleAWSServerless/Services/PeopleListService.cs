
namespace LambdaPeopleAWSServerless.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using LambdaPeopleAWSServerless.Models;

    public class PeopleListService: IPeopleListService
    {
        private readonly Dictionary<string, string> _peopleListHome = new Dictionary<string, string>();

        public void AddItemsToPeopleList(PeopleListModel peopleList)
        {
            _peopleListHome.Add(peopleList.Name, peopleList.LastName);
        }

        public Dictionary <string, string> GetItemsFromPeopleList()
        {
            return _peopleListHome;
        }

        public void RemoveItem(string name)
        {
            _peopleListHome.Remove(name);           
        }
    }
}
