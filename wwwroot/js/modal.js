async function fetchProduto(id) {
    const apiUrl = `https://localhost:7093/api/Restaurante/${id}`; // Ajuste para o endpoint correto

    try {
        const response = await fetch(apiUrl);

        if (!response.ok) {
            throw new Error(`Erro ao buscar produto: ${response.status}`);
        }

        const produto = await response.json();
        console.log(produto); // Verifique a estrutura do objeto

        const produtoNome = produto.nome; // Ajuste se necessário
        const produtoValor = produto.valor;

        console.log("Tentando acessar o elemento:", document.getElementById('produto-nome')); // Verifica se o elemento existe

        if (produtoNome) {
            const produtoNomeDiv = document.getElementById('produto-nome');
            produtoNomeDiv.innerHTML = `<pre><p>O Valor é: </p>${JSON.stringify(produtoValor * 2, null, 2)}</pre>`;
        } else {
            console.error('Nome do produto não encontrado.');
        }
    } catch (error) {
        console.error('Erro ao buscar produto:', error);
    }
}

const produtoId = 1; // Substitua pelo ID do produto que você deseja buscar
fetchProduto(produtoId);