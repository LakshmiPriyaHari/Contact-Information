using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Personal_Information_Class
{
    internal class VM : INotifyPropertyChanged
    {
        private static VM vm;
        public static VM Instance
        {
            get
            {
                vm ??= new VM();
                return vm;
                //if(vm == null)
                //    vm = new VM();
                //return vm;
            }
        }
        public BindingList<Members> ListOfMember { get; set; } = new BindingList<Members>();

        private Members selectedItem;
        public Members SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; propChange(); }
        }
       
        private VM()
        {
            Members myInfo = new Members();
            ListOfMember.Add(myInfo);

            Members friendInfo = new Members("John", "Kitchener" , 24 , "000-000");
            ListOfMember.Add(friendInfo);

            Members familyInfo = new Members();
            familyInfo.Name = "Dan";
            familyInfo.Address = "Toronto";
            familyInfo.Age = 23;
            familyInfo.PhoneNumber = "999-999-9999";
            ListOfMember.Add(familyInfo);
        }
        #region Prop Change
        public event PropertyChangedEventHandler PropertyChanged;

        private void propChange([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
