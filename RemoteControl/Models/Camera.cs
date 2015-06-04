//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemoteControl.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Camera
    {
        public Camera()
        {
            this.UserCamera = new HashSet<UserCamera>();
            this.Queue = new HashSet<Queue>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string CameraPath { get; set; }
        public State State { get; set; }
        public Category Category { get; set; }
        public Nullable<int> ControllerID_Id { get; set; }
        public CameraAction CameraAction { get; set; }
        public string UserManager { get; set; }
        public string UserOwner { get; set; }
        public bool IsPublic { get; set; }
        public bool IsWork { get; set; }
    
        public virtual LANController LANController { get; set; }
        public virtual ICollection<UserCamera> UserCamera { get; set; }
        public virtual ICollection<Queue> Queue { get; set; }
    }
}
