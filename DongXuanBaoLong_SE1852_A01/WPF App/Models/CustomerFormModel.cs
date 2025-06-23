using System.ComponentModel;

namespace WPF_App.Models
{
    public class CustomerFormModel : INotifyPropertyChanged
    {
        private string companyName;
        private string contactName;
        private string contactTitle;
        private string address;
        private string phone;

        public string CompanyName
        {
            get => companyName;
            set
            {
                if (companyName != value)
                {
                    companyName = value;
                    OnPropertyChanged(nameof(CompanyName));
                }
            }
        }

        public string ContactName
        {
            get => contactName;
            set
            {
                if (contactName != value)
                {
                    contactName = value;
                    OnPropertyChanged(nameof(ContactName));
                }
            }
        }

        public string ContactTitle
        {
            get => contactTitle;
            set
            {
                if (contactTitle != value)
                {
                    contactTitle = value;
                    OnPropertyChanged(nameof(ContactTitle));
                }
            }
        }

        public string Address
        {
            get => address;
            set
            {
                if (address != value)
                {
                    address = value;
                    OnPropertyChanged(nameof(Address));
                }
            }
        }

        public string Phone
        {
            get => phone;
            set
            {
                if (phone != value)
                {
                    phone = value;
                    OnPropertyChanged(nameof(Phone));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
