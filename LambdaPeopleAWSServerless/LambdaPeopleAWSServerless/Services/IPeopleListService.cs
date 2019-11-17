
namespace LambdaPeopleAWSServerless.Services
{
    using System.Collections.Generic;
    using LambdaPeopleAWSServerless.Models;

    public interface IPeopleListService
    {
        Dictionary<string, string> GetItemsFromPeopleList();
        void AddItemsToPeopleList(PeopleListModel peopleList);
        void RemoveItem(string name);
    }
}