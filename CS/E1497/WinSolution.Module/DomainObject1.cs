using DevExpress.ExpressApp.Model;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using System;

namespace WinSolution.Module {
    [DefaultClassOptions]
    public class DomainObject1 : BaseObject {
        public DomainObject1(Session session) : base(session) { }
        private DateTime _createdOn;
        [ModelDefault("DisplayFormat", "{0: ddd, dd MMMM yyyy hh:mm:ss tt}")]
        [ModelDefault("EditMask", "ddd, dd MMMM yyyy hh:mm:ss tt")]
        [ModelDefault("PropertyEditorType", "WinSolution.Module.Win.MyDatePropertyEditor")]
        public DateTime CreatedOn {
            get { return _createdOn; }
            set { SetPropertyValue("CreatedOn", ref _createdOn, value); }
        }
    }
}
