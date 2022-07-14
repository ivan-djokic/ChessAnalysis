// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using System.Linq.Expressions;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Utils
{
	public partial class Options
	{
		private MVVMContextFluentAPI<OptionsBindModel> m_binding;
		private readonly OptionsBindModel m_optionsModel = new();

		private Options()
		{
			CreateBinding();
		}

		public static Action? BoardOptionsChanged;

		public void Bind(CheckEdit control, Expression<Func<OptionsBindModel, bool>> expression)
		{
			m_binding.SetBinding(control, c => c.Checked, expression);
		}

		public void Bind(ColorPickEdit control, Expression<Func<OptionsBindModel, Color>> expression)
		{
			m_binding.SetBinding(control, c => c.Color, expression);
		}

		public void Bind(TextEdit control, Expression<Func<OptionsBindModel, string>> expression)
		{
			m_binding.SetBinding(control, c => c.EditValue, expression);
		}

		private void CreateBinding()
		{
			var context = new MVVMContext();
			context.SetViewModel(typeof(OptionsBindModel), m_optionsModel);

			m_binding = context.OfType<OptionsBindModel>();
		}

		private void RaiseOnChange()
		{
			m_optionsModel.RaisePropertiesChanged();
			BoardOptionsChanged?.Invoke();
			Utils.Theme.ApplyTheme();
		}
	}
}
