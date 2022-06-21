using ChessAnalysis.Utils;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Controls
{
    public partial class BoardTab : XtraUserControl
    {
        public BoardTab()
        {
            InitializeComponent();
            BindComponents();
        }

        private void BindComponents()
        {
            Options.Instance.Bind(colorFill, model => model.FieldFillColor);
            Options.Instance.Bind(colorEmpty, model => model.FieldEmptyColor);
            Options.Instance.Bind(chxCoords, model => model.ShowCoordinates);
            Options.Instance.Bind(chxBestMove, model => model.MarkIfBestMoveIsPlayed);
            Options.Instance.Bind(rbClassic, model => model.PieceClassic);
            Options.Instance.Bind(rbNeo, model => model.PieceNeo);
            Options.Instance.Bind(rbWood, model => model.PieceWood);
        }
    }
}
