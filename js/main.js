
//pokemon inicial
var estado = 0;
var numero = 1 ;
var front_shiny = "normal";
var lado = "normal";
let nomepoke;
let imagempoke;

var som_botao = document.querySelector("#musica_botao");



function loadpk() {
    let url = `https://pokeapi.co/api/v2/pokemon/${numero}/`;
    let urltexto = `https://pokeapi.co/api/v2/pokemon-species/${numero}`  //flavor_text

    fetch(url)
    //encadeamente de função
    .then((response) => {
        //pega a resposta e converte para um json
        return response.json();
    })
    
    //diz respeito ao dados e como serão tratados/o que faremos com os dados json
    .then((data) => {
        //limpa o nosso console
        console.clear();
    
        //Realizamos a verificação do tipo do sprite - normal ou shiny
        let img = data['sprites']['front_default']

        if (lado == "normal" && front_shiny == "normal"){
            img = data['sprites']['front_default'];
        }else if (lado == "costas" && front_shiny == "normal"){
            img = data['sprites']['back_default']
        }else if (lado == "normal" && front_shiny == "shiny"){
            img = data['sprites']['front_shiny'];
        }else{
            img = data['sprites']['back_shiny']
        }

        background = document.getElementById("box_pokemon_data");
        background.style.backgroundColor = "rgb(172 180 190)"

        background2 = document.getElementById("vi");
        background2.style.backgroundColor = "rgb(172, 180, 190)";
        background2.style.overflowY = "auto";

        description = document.getElementById("description");
        description.style.backgroundColor = "#316736";

        document.getElementById("id").innerHTML = `no.${data['id']}`
        document.getElementById("name").innerHTML = data['name'].toUpperCase();
        

        imagem_pokemon = document.getElementById("div_poke");
        imagem_pokemon.innerHTML = ""
        
        let poke = document.createElement("img");   
        poke.setAttribute("id","pokemon");
        poke.setAttribute("class","img_pokemon");
        poke.setAttribute("src", img);

        imagem_pokemon.appendChild(poke)

        //limpa os tipos
        let caixatipo = document.getElementById("tipo")
        caixatipo.innerText = ""

        //função para mostrar todos os tipos
        data.types.forEach(type => {
            //verifica o tipo do pokemon e atribui uma cor especifica
            let tipo = type.type.name
            switch(tipo){
                case "bug":
                    tipo = "yellowgreen"
                    break;
                case "dark":
                    tipo = 'darkslategray';
                    break;
                case "dragon":
                    tipo = "blueviolet"
                    break;
                case "electric":
                    tipo = "rgb(255, 204, 0)"
                    break;
                case "fairy":
                    tipo = "rgb(199, 146, 154)"
                    break;
                case "fighting":
                    tipo = "tomato"
                    break; 
                case "fire":
                    tipo = "red"
                    break;
                case "flying":
                    tipo = "rgb(182, 139, 234)"
                    break;
                case "ghost":
                    tipo = "rgb(86, 77, 148)"
                    break;
                case "grass":
                    tipo = "rgb(117, 169, 38)"
                    break;
                case "ground":
                    tipo = "rgb(188, 180, 104)"
                    break;
                case "ice":
                    tipo = "rgb(141, 196, 196)"
                    break;
                case "normal":
                    tipo = "burlywood"
                    break;
                case "poison":
                    tipo = "darkviolet";
                    break;
                case "psychic":
                    tipo = "palevioletred"
                    break;
                case "rock":
                    tipo = "rgb(145, 129, 53)"
                    break;
                case "steel":
                    tipo = "rgb(114, 118, 130)"
                    break;
                case "water":
                    tipo = "rgb(22, 101, 219)"
                    break;        
            }

            let outo = document.createElement("div");
            outo.setAttribute('id', 'tipo');
            outo.style.width = '120px';
            outo.style.height = '25px';
            outo.style.backgroundColor = tipo
            outo.style.borderRadius = '15px';
            outo.style.textAlign = "center";
            outo.style.fontSize = "20px";
            outo.style.color = "white";
            outo.style.marginBottom = "5px";
            outo.innerText = type.type.name;
            
            caixatipo.appendChild(outo);
        });
        
        //apresentação dos dados no container dados pokemon/movimentos
            //dados pokemon
        
        poke_nome = document.getElementById("pokemon_name");  
        poke_status = document.getElementById("pokemon_status");
        poke_hp = document.getElementById("pokemon_hp");
        poke_attack = document.getElementById("pokemon_attack");
        poke_defense = document.getElementById("pokemon_defense");
        poke_speed = document.getElementById("pokemon_speed");
        poke_experience = document.getElementById("pokemon_experience");

        poke_nome.innerText = data['name'];
        poke_status.innerHTML = "Status:";
        poke_hp.innerText = "hp: " + data.stats[0]['base_stat'];
        poke_attack.innerText = "attack: " + data.stats[1]['base_stat'];
        poke_defense.innerText = "defense: " + data.stats[2]['base_stat'];
        poke_speed.innerText = "speed: " + data.stats[5]['base_stat'];
        poke_experience.innerHTML = "Experience: " + data.base_experience;

        let nome_pokemon = data['name'];
        
        nomepoke = nome_pokemon
        imagempoke = img
    })

    //captura o erro e retorna no console
    .catch((erro)=>{
        console.log("erro" + erro);
    });
    //função para aguardar um segundo
    //await new Promise(resolve => setTimeout(resolve, 1000));


    fetch(urltexto)
    .then((response) => { return response.json(); })

    .then((data) =>{
        //console.log(data)
        //limpa o nosso console
        console.clear();

        console.log(data.flavor_text_entries[1].language)
        let poketext = "";

        //console.log(data)
        let language = "";
        let contador = 1;

        while (language!="en"){
            contador++;
            language = data.flavor_text_entries[contador].language["name"];
            poketext = data.flavor_text_entries[contador].flavor_text;
        }
        boxtext = document.getElementById("box_description_text");
        
        //slit() e join() - Funcação para realizar a concatenção do texto.
        let textoconcat =  poketext.split("\n").join(" ");
        boxtext.innerText = textoconcat
    })

    .catch((erro)=>{
        console.log("erro" + erro);
    });
}

//Ligando a Pokedex
ligar = document.getElementById("ligar");
ligar.addEventListener("click", ligando);
function ligando(){
    luz_on = document.getElementById("light_on");
    if(estado==0){
        estado = 1;
        luz_on.className = "icon_bot_on";
        som_botao.play();
        //indice.value = "1"
        //Inicia método principal
        loadpk();
    }else{
        estado = 0
        numero = 1
        front_shiny = "normal";
        lado = "normal";
        luz_on.className = "icon_bot";
        img_shine = document.getElementById("img_shine");
        img_shine.style.visibility = "hidden"
        limpar();   
    }
}

    //musica - pokedex
let ligou = document.querySelector("#ligar");
ligou.addEventListener('click', () => {
    if(estado == 1){
        setTimeout(function(){
            musica.play();
        }, 1000);
    }else if(estado == 0){
        musica.pause()
        musica.currentTime = 0;
    }
})

//pokemon shine
let shine = document.getElementById("shine")
shine.addEventListener("click", novopoke)
function novopoke(){
    if(estado==1){
        if (front_shiny == "normal"){
            front_shiny = "shiny";
        }else{
            front_shiny = "normal"
        }    
        loadpk()
        som_botao.currentTime = 0;
        som_botao.play();
    }
    
    img_shine = document.getElementById("img_shine");
    if(lado == "shiny" || front_shiny == "shiny"){
    img_shine.setAttribute("src", "images/star2.png");
        img_shine.style.visibility = "visible"
    }else if(lado == "normal" || front_shiny == "normal"){
        img_shine.style.visibility = "hidden"
    }
}

//rotacionar pokemon
let rotacao = document.getElementById("rotacao")
rotacao.addEventListener("click",rotacionar)
function rotacionar(){ 
    if(estado==1){
        if (lado == "normal"){
            lado = "costas";
        }else{
            lado = "normal"
        }   
    
        loadpk();
        som_botao.currentTime = 0;
        som_botao.play();
    }
   
    img_shine = document.getElementById("img_shine");
    if(lado == "shiny" || front_shiny == "shiny"){
    img_shine.setAttribute("src", "images/star2.png");
        img_shine.style.visibility = "visible"
    }else if(lado == "normal" || front_shiny == "normal"){
        img_shine.style.visibility = "hidden"
    }
}

//Pesquisar pokemon
let pesquisa = document.getElementById("btn_poke_pesquisa");
pesquisa.addEventListener("click", pesquisar)
function pesquisar(){
    let indexpokemon = document.getElementById("caixa_indice").value;
    if (indexpokemon>0) {
        numero = indexpokemon
        loadpk()
        som_botao.currentTime = 0;
        som_botao.play();
    }else{
        alert("digite um valor valido");
        som_botao.currentTime = 0;
        som_botao.play();
    }
}

//Próximo Pokemon
let anterior = document.getElementById("anterior")
anterior.addEventListener("click", antes)
function antes(){
    if(estado==1){
        if (numero >0) {
            numero --;       
            loadpk()
            som_botao.currentTime = 0;
            som_botao.play();
        }
    }
}

//pokemon anterior
let proximo = document.getElementById("proximo")
proximo.addEventListener("click", prox)
function prox(){
    if(estado==1){
        numero ++;
        loadpk();
        som_botao.currentTime = 0;
        som_botao.play();
    }
}

//função para limpar html ao desligar a pokedex
function limpar() {
    background = document.getElementById("box_pokemon_data");
    description = document.getElementById("description");
    boxtext = document.getElementById("box_description_text");
    pokeid = document.getElementById("id");
    pokename = document.getElementById("name");
    poketipo = document.getElementById("tipo");
    pokeimagem = document.getElementById("div_poke");
    poke_name = document.getElementById("pokemon_name");
    vi = document.getElementById("vi");
    pokehp = document.getElementById("pokemon_hp");
    poke_status = document.getElementById("pokemon_status");
    pokeattack = document.getElementById("pokemon_attack");
    pokedefense = document.getElementById("pokemon_defense");
    pokespeed = document.getElementById("pokemon_speed");
    caixa_indice = document.getElementById("caixa_indice");

    background.style.backgroundColor = "#171616";
    background2.style.backgroundColor = "#171616";
    description.style.backgroundColor = "#2e5631";
    vi.style.overflow = "hidden";

    boxtext.innerHTML = "";
    poke_status.innerHTML = "";
    pokeid.innerHTML = "";
    pokename.innerHTML = "";
    poketipo.innerHTML = "";
    pokeimagem.innerHTML = "";
    poke_name.innerHTML = "";

    pokehp.innerHTML = "";
    pokeattack.innerHTML = "";
    pokespeed.innerHTML = "";
    pokedefense.innerHTML = "";
    caixa_indice.value = "";
}
