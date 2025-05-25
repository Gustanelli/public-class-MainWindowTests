
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotIATests
{
    [TestClass]
    public class IARespostaTests
    {
        [TestMethod]
        public void ObterResposta_DeveRetornarTexto_ParaPerguntaValida()
        {
            var ia = new MainWindow();
            string resposta = ia.ObterRespostaDaIA("O que é RAM?");
            Assert.IsFalse(string.IsNullOrEmpty(resposta));
        }
    }
}
