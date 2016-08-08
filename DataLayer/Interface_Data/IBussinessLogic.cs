﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Interface_Data
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBussinessLogic" in both code and config file together.
    [ServiceContract]
    public interface IBussinessLogic
    {

        //Author Bussiness Logic Implement
        [OperationContract]
        bool AddAuthor(AuthorData a);
        [OperationContract]
        bool Remove(AuthorData a);
        [OperationContract]
        bool Update(AuthorData a);

        //Account Business Logic Implement
        [OperationContract]
        bool AddAccount(AccountData b);
        [OperationContract]
        bool RemoveAccount(AccountData b);
        [OperationContract]
        bool checkLogin(string username, string password);


        //Author Bussiness Logic Implement


    }
}
