using System;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Win.Editors;

namespace WinSolution.Module.Win {
    [PropertyEditor(typeof(DateTime))]
    public class MyDatePropertyEditor : DatePropertyEditor {
        public MyDatePropertyEditor(Type objectType, IModelMemberViewItem item) : base(objectType, item) { }
        protected override void SetupRepositoryItem(DevExpress.XtraEditors.Repository.RepositoryItem item) {
            base.SetupRepositoryItem(item);
            RepositoryItemDateTimeEdit defaultItem = (RepositoryItemDateTimeEdit)item;
            defaultItem.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            defaultItem.VistaEditTime = DevExpress.Utils.DefaultBoolean.True;
        }
    }
}