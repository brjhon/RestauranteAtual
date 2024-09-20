using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Restaurante.Pages
{
    public class CardapioModel : PageModel
    {
            public List<Cardapio> x { get; set; } = new List<Cardapio>();
            public void OnGet()
            {
                x = new List<Cardapio>
    {
        new Cardapio
{
        ID = 01,
        Titulo = @" <h1>Salm�o Grelhado com Crosta de Ervas</h1>",
        Descricao =@"<p>Um fil� de salm�o fresco, grelhado � perfei��o e coberto com uma crosta crocante de ervas finas. Servido com um molho de lim�o siciliano e acompanhado de aspargos salteados, este prato � leve, saboroso e visualmente impressionante.</p>",
        ImagemUrl = "./Imagens/03.png",
        
},
new Cardapio
{
    ID = 02,
    Titulo = @"<h1>Risoto de Cogumelos Trufados</h1>",
    Descricao =@"<p>
        Um risoto cremoso feito com arroz arb�reo, delicadamente cozido em um caldo de legumes arom�tico e enriquecido com uma mistura de cogumelos selvagens. 
        Finalizado com azeite de trufa e lascas de queijo parmes�o, este prato � uma verdadeira celebra��o de sabores terrosos e sofisticados.
    </p>",
    ImagemUrl = "./Imagens/01.png",
    
},

new Cardapio
{
    ID = 03,
    Titulo = @"<h1>Fil� Mignon ao Molho de Vinho Tinto</h1>",
    Descricao =@"<p>Um suculento fil� mignon grelhado, servido com um rico molho de vinho tinto, cebolas caramelizadas e um toque de alecrim. Acompanhado por pur� de batata trufado e legumes grelhados, � uma combina��o perfeita que promete encantar o paladar.</p>",
    ImagemUrl = "./Imagens/02.jpg",
    
}



        };
            }
        }
    }


