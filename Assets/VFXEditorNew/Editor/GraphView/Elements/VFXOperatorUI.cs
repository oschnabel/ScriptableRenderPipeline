using System;
using System.Collections.Generic;
using System.Linq;
using RMGUI.GraphView;
using UnityEngine;
using UnityEngine.RMGUI;
using UnityEngine.RMGUI.StyleEnums;
using UnityEngine.RMGUI.StyleSheets;

namespace UnityEditor.VFX.UI
{
    class VFXOperatorUI : Node
    {
        public VFXOperatorUI()
        {
        }

        public override void OnDataChanged()
        {
            base.OnDataChanged();
            var presenter = GetPresenter<VFXOperatorPresenter>();
            if (presenter == null || presenter.Operator == null)
                return;

            presenter.Operator.position = presenter.position.position;
            presenter.Operator.collapsed = !presenter.expanded;
        }
    }
}