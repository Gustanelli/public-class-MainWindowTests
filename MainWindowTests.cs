
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DotIATests
{
    [TestClass]
    public class MainWindowTests
    {
        [TestMethod]
        public void VerificarSeFoiAvaliado_DeveRetornarTrue_QuandoRespostaForAvaliada()
        {
            var mainWindow = new MainWindow();
            mainWindow.FoiUtil = true;

            bool resultado = mainWindow.VerificarSeFoiAvaliado();

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ObterRespostaDaIA_DeveRetornarResposta_QuandoPerguntaForValida()
        {
            var mainWindow = new MainWindow();
            string pergunta = "Como atualizar o Windows?";

            string resposta = mainWindow.ObterRespostaDaIA(pergunta);

            Assert.IsFalse(string.IsNullOrEmpty(resposta));
        }
    }
}
