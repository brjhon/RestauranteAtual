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
        Titulo = @" <h1>Salmão Grelhado com Crosta de Ervas</h1>",
        Descricao =@"<p>Um filé de salmão fresco, grelhado à perfeição e coberto com uma crosta crocante de ervas finas. Servido com um molho de limão siciliano e acompanhado de aspargos salteados, este prato é leve, saboroso e visualmente impressionante.</p>",
        ImagemUrl = "./Imagens/03.png",
        
},
new Cardapio
{
    ID = 02,
    Titulo = @"<h1>Risoto de Cogumelos Trufados</h1>",
    Descricao =@"<p>
        Um risoto cremoso feito com arroz arbóreo, delicadamente cozido em um caldo de legumes aromático e enriquecido com uma mistura de cogumelos selvagens. 
        Finalizado com azeite de trufa e lascas de queijo parmesão, este prato é uma verdadeira celebração de sabores terrosos e sofisticados.
    </p>",
    ImagemUrl = "./Imagens/01.png",
    
},

new Cardapio
{
    ID = 03,
    Titulo = @"<h1>Filé Mignon ao Molho de Vinho Tinto</h1>",
    Descricao =@"<p>Um suculento filé mignon grelhado, servido com um rico molho de vinho tinto, cebolas caramelizadas e um toque de alecrim. Acompanhado por purê de batata trufado e legumes grelhados, é uma combinação perfeita que promete encantar o paladar.</p>",
    ImagemUrl = "./Imagens/02.jpg",
    
}



        };
            }
        }
    }


