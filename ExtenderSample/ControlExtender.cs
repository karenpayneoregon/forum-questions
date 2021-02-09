using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExtenderSample
{
    [ProvideProperty("Custom1", typeof(Control))]
    [ProvideProperty("Custom2", typeof(Control))]
    public class ControlExtender : Component, IExtenderProvider
    {
        private Hashtable _controls = new Hashtable();
        public bool CanExtend(object extendee)
        {
            return extendee is Control;
        }

        public string GetCustom1(Control control)
        {
            if (_controls.ContainsKey(control))
            {
                return (string)_controls[control];
            }

            return null;
        }
        public string GetCustom2(Control control)
        {
            if (_controls.ContainsKey(control))
            {
                return (string)_controls[control];
            }

            return null;
        }
        public void SetCustom1(Control control, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                _controls.Remove(control);
            }
            else
            {
                _controls[control] = value;
            }
        }
        public void SetCustom2(Control control, int? value)
        {
            if (!value.HasValue)
            {
                _controls.Remove(control);
            }
            else
            {
                _controls[control] = value;
            }
        }
    }

}
