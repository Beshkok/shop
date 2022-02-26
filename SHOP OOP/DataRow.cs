using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP_OOP
{
    class DataRow
    {
        public object id { get; set; }
        public object client_name { get; set; }
        public object phone_number { get; set; }
        public object order_text { get; set; }
        public object address { get; set; }

    public DataRow(object _id, object _client_name, object _phone_number, object _order_text, object _address) {

            id = _id;
            client_name = _client_name;
            phone_number = _phone_number;
            order_text = _order_text;
            address = _address;
    }

    public void DataChange(object _id, object _client_name, object _phone_number, object _order_text, object _address)
        {

            id = _id;
            client_name = _client_name;
            phone_number = _phone_number;
            order_text = _order_text;
            address = _address;
        }


    }
}
