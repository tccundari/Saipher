using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCV.Entity;
using Ninject;
using SCV.Domain.Interface;
using SCV.Business;
using SCV.Business.Modulos;

namespace SCV.Presentation.Controles
{
    public partial class UcModuloPlanoVoo : UserControl
    {
        private bool _modoEdicao = false;
        private TB_SCV_PLANO_VOO _planoVoo = null;

        public UcModuloPlanoVoo()
        {
            InitializeComponent();
        }

        private void ucPlanoVooCadastro_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            try
            {
                ResetarInterface();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Ninject.IKernel _kernel = new StandardKernel(new ModuloPlanoVoo());
                BusinessPlanoVoo bsplanoVoo = _kernel.Get<BusinessPlanoVoo>();
                BusinessFrota bsfrota = _kernel.Get<BusinessFrota>();

                if (seletorFrota.FrotaSelecionada == null)
                    throw new ApplicationException("Aeronave não selecionada");
                if (seletorCentroOperacaoOri.CentroOperacaoSelecionado == null)
                    throw new ApplicationException("Centro de Operações Origem não selecionado");
                if (seletorCentroOperacaoDes.CentroOperacaoSelecionado == null)
                    throw new ApplicationException("Centro de Operações Destino não selecionado");

                _planoVoo = new TB_SCV_PLANO_VOO()
                {
                    ID_SCV_PLANO_VOO = _planoVoo != null && _planoVoo.ID_SCV_PLANO_VOO > 0? _planoVoo.ID_SCV_PLANO_VOO : 0,
                    BT_ATIVO = true,
                    DT_VOO = dtVoo.DateTimePicker,
                    FK_SCV_COMPANHIA = ((TB_SCV_COMPANHIA)sltCompanhia.SelectedItem).ID_SCV_COMPANHIA,
                    FK_SCV_FROTA = bsfrota.SelecionarPorFrotaAeronava(seletorFrota.FrotaSelecionada).ID_SCV_FROTA,
                    FK_SCV_CENTRO_OPERACAO_ORIGEM = seletorCentroOperacaoOri.CentroOperacaoSelecionado.ID_SCV_CENTRO_OPERACAO,
                    FK_SCV_CENTRO_OPERACAO_DESTINO = seletorCentroOperacaoDes.CentroOperacaoSelecionado.ID_SCV_CENTRO_OPERACAO
                };

                if (_modoEdicao)
                {
                    bsplanoVoo.Atualizar(_planoVoo);

                    MessageBox.Show("Plano de Voo atualizado com sucesso!");
                }
                else
                {
                    bsplanoVoo.Criar(_planoVoo);

                    if (_planoVoo != null && _planoVoo.ID_SCV_PLANO_VOO > 0)
                    {
                        MessageBox.Show("Plano de Voo criado com sucesso!");
                    }
                }

                ResetarInterface();
                CarregarUltimosPlanosVoo();
                _planoVoo = null;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void CarregarUltimosPlanosVoo()
        {
            try
            {
                Ninject.IKernel _kernel = new StandardKernel(new ModuloPlanoVoo());
                BusinessPlanoVoo planoVoo = _kernel.Get<BusinessPlanoVoo>();

                dgvPlanosVoo.DataSource = planoVoo.SelecionarTodos().Take(10).ToList();

                ckbCentroOperacaoDes.Checked = false;
                ckbCentroOperacaoOri.Checked = false;
                txtFiltroNumeroVoo.TextBox = string.Empty;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void sltCompanhia_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void sltCompanhia_SelectedIndexChanged(object sender, EventArgs e)
        {
            seletorFrota.Companhia = (TB_SCV_COMPANHIA)sltCompanhia.SelectedItem; ;
        }

        private void dgvPlanosVoo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                Ninject.IKernel _kernel = new StandardKernel(new ModuloPlanoVoo());
                BusinessPlanoVoo bsplanoVoo = _kernel.Get<BusinessPlanoVoo>();
                var plnoVooInformacao = new VW_SCV_PLANO_VOO_INFORMACAO();

                if (e.RowIndex >= 0)
                {
                    plnoVooInformacao = (VW_SCV_PLANO_VOO_INFORMACAO)senderGrid.Rows[e.RowIndex].DataBoundItem;
                }

                if (e.ColumnIndex == Editar.Index && e.RowIndex >= 0)
                {
                    _planoVoo = bsplanoVoo.SelecionarPlanoVooPorID(plnoVooInformacao.ID_SCV_PLANO_VOO);
                    _modoEdicao = true;
                    CarregarPlanoVooParaEdição(plnoVooInformacao);
                }

                if (e.ColumnIndex == Excluir.Index && e.RowIndex >= 0)
                {
                    if (MessageBox.Show("Deseja realmente excluir o Plano de Voo: " + plnoVooInformacao.NUMERO_VOO, "Exlusão de Plano de Voo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bsplanoVoo.Excluir(plnoVooInformacao);
                        MessageBox.Show("Plano de Voo excluído com sucesso!");
                        CarregarPlanoVooParaEdição(plnoVooInformacao);
                    }
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void ResetarInterface()
        {
            try
            {
                _modoEdicao = false;

                txtNumeroVoo.Visible = _modoEdicao;
                btnCadastrar.Text = "Cadastrar";
                btnCancelar.Visible = _modoEdicao;

                txtNumeroVoo.TextBox = string.Empty;

                dtVoo.DateTimePicker = DateTime.Today;

                Ninject.IKernel _kernel = new StandardKernel(new ModuloCompanhia());
                BusinessCompanhia companhia = _kernel.Get<BusinessCompanhia>();

                sltCompanhia.CarregarComboBox<TB_SCV_COMPANHIA>(companhia.SelecionarTodos().ToList(), "NM_COMPANHIA");
                seletorCentroOperacaoOri.CentroOperacaoSelecionado = null;
                seletorCentroOperacaoDes.CentroOperacaoSelecionado = null;

                CarregarUltimosPlanosVoo();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void CarregarPlanoVooParaEdição(VW_SCV_PLANO_VOO_INFORMACAO objPlanoVooInformacao)
        {
            try
            {
                if (!_modoEdicao)
                    return;

                txtNumeroVoo.Visible = _modoEdicao;
                btnCadastrar.Text = "Atualizar";
                btnCancelar.Visible = _modoEdicao;

                txtNumeroVoo.TextBox = objPlanoVooInformacao.NUMERO_VOO;
                dtVoo.DateTimePicker = _planoVoo.DT_VOO;
                seletorFrota.SelecionarPorIDFrota(_planoVoo.FK_SCV_FROTA);
                seletorCentroOperacaoOri.SelecionarPorIDCentroOperacao(_planoVoo.FK_SCV_CENTRO_OPERACAO_ORIGEM);
                seletorCentroOperacaoDes.SelecionarPorIDCentroOperacao(_planoVoo.FK_SCV_CENTRO_OPERACAO_DESTINO);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetarInterface();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Ninject.IKernel _kernel = new StandardKernel(new ModuloPlanoVoo());
                BusinessPlanoVoo planoVoo = _kernel.Get<BusinessPlanoVoo>();

                int idCentroOperacaoOrigem = 0;
                int idCentroOperacaoDestino = 0;

                if (ckbCentroOperacaoOri.Checked)
                {
                    if(seletorCentroOperacaoOri.CentroOperacaoSelecionado == null)
                    {
                        MessageBox.Show("Selecione um Centro de Operação Origem.");
                        return;
                    }
                    idCentroOperacaoOrigem = seletorCentroOperacaoOri.CentroOperacaoSelecionado.ID_SCV_CENTRO_OPERACAO;
                }

                if (ckbCentroOperacaoDes.Checked)
                {
                    if (seletorCentroOperacaoDes.CentroOperacaoSelecionado == null)
                    {
                        MessageBox.Show("Selecione um Centro de Operação Destino.");
                        return;
                    }
                    idCentroOperacaoDestino = seletorCentroOperacaoDes.CentroOperacaoSelecionado.ID_SCV_CENTRO_OPERACAO;
                }

                dgvPlanosVoo.DataSource = planoVoo.SelecionarPorNumeroVooOrigemDestino(txtFiltroNumeroVoo.TextBox, idCentroOperacaoOrigem, idCentroOperacaoDestino);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
