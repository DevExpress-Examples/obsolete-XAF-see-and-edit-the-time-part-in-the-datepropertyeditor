using System;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.ExpressApp;
using DevExpress.XtraEditors;

namespace WinSolution.Module.Win {
    [PropertyEditor(typeof(DateTime))]
    public class MyDatePropertyEditor : DatePropertyEditor {
        public MyDatePropertyEditor(Type objectType, DictionaryNode info) : base(objectType, info) { }
        protected override object CreateControlCore() {
            DateEdit control = (DateEdit)base.CreateControlCore();
            SetupRepositoryItemDateTimeEdit((RepositoryItemDateTimeEdit)control.Properties);
            return control;
        }
        protected override void SetupRepositoryItem(DevExpress.XtraEditors.Repository.RepositoryItem item) {
            base.SetupRepositoryItem(item);
            SetupRepositoryItemDateTimeEdit((RepositoryItemDateTimeEdit)item);
        }
        protected virtual void SetupRepositoryItemDateTimeEdit(RepositoryItemDateTimeEdit item) {
            item.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            item.VistaEditTime = DevExpress.Utils.DefaultBoolean.True;
        }
    }
}
