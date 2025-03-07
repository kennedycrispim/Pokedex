* {
  margin: 0px;
  padding: 0px;
}

::selection {
  background-color: #ebebeb;
  color: rgb(11, 11, 11);
}

@font-face {
  font-family: pixelgame;
  src: url(../fonte/PixelGameFont.ttf);
}
* {
  font-family: pixelgame;
}

body {
  background-image: url("../images/background2.avif");
  background-repeat: repeat;
  background-size: auto;
  background-position: center;
}

.pokedex {
  width: auto;
  min-height: 100vh;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}

.visor {
  width: 700px;
  height: 130px;
  background-color: #b11828;
  border-radius: 15px;
  display: flex;
  padding: 15px;
  box-sizing: border-box;
  box-shadow: 6px 2px 0px 0px rgb(87, 7, 15);
  margin: 0 auto;
}
@media (max-width: 767px) {
  .visor {
    width: 85vw;
    height: auto;
    border-radius: 15px 15px 15px 0px;
  }
}
@media (min-width: 768px) and (max-width: 1023px) {
  .visor {
    width: 80vw;
    height: auto;
    border-radius: 15px 15px 15px 0px;
  }
}

.main {
  width: 50px;
  height: 50px;
  display: grid;
  background-color: #ebebeb;
  border-radius: 50%;
  border: 4px solid #a8acb0;
  background: radial-gradient(farthest-corner at 15px 10px, rgba(201, 214, 251, 0.93) 0%, rgb(31, 99, 196) 50%, rgb(4, 12, 23) 100%);
  background-blend-mode: overlay;
  margin-top: 10px;
  box-shadow: 3px 0px 10px 1px rgb(87, 7, 15);
  margin-left: 10px;
  margin-right: 20px;
}

.second {
  width: 20px;
  height: 20px;
  border-radius: 50%;
  margin: 5px;
  margin-top: 10px;
  box-shadow: 3px 0px 10px 1px rgb(87, 7, 15);
  border: 2px solid #3e3e3e;
}

.red {
  background: radial-gradient(farthest-corner at 7px 5px, #f4a9a9 0%, #b22626 50%, rgb(87, 7, 15) 100%);
}

.yellow {
  background: radial-gradient(farthest-corner at 7px 5px, rgb(255, 223, 164) 0%, rgb(235, 166, 37) 50%, rgb(65, 44, 4) 100%);
}

.green {
  background: radial-gradient(farthest-corner at 7px 5px, rgb(166, 255, 173) 0%, rgb(2, 180, 17) 50%, rgb(2, 44, 5) 100%);
}

.poke-body {
  width: 680px;
  height: 720px;
  background-color: #b11828;
  border-radius: 0px 0px 15px 15px;
  box-shadow: inset 0px 5px 10px 0px rgb(87, 7, 15);
  margin: 0 auto;
  display: grid;
  gap: 5px;
  grid-template-areas: "main-visor main-visor" "description data";
  grid-template-columns: 1fr 1fr;
  grid-template-rows: 2fr 1fr;
}
@media (max-width: 767px) {
  .poke-body {
    width: 85vw;
    grid-template-columns: 1fr 1fr;
    grid-template-rows: 2fr 1fr;
  }
}
@media (min-width: 768px) and (max-width: 1023px) {
  .poke-body {
    width: 80vw;
    grid-template-rows: 2fr 1fr;
  }
}

.main-visor {
  width: 100%;
  height: 100%;
  border-radius: 10px;
  margin: 0 auto;
  grid-area: main-visor;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}

.description-visor {
  grid-area: description;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  align-items: flex-end;
  justify-content: flex-start;
}

.description {
  width: 220px;
  height: 170px;
  background-color: #2e5631;
  color: #061206;
  font-size: 15px;
  padding: 8px;
  border: 2px solid #376e3b;
  box-shadow: inset 0px 0px 10px 5px #376e3b;
  border-radius: 10px;
  text-align: left;
}
@media (max-width: 767px) {
  .description {
    width: 30vw;
  }
}
@media (min-width: 768px) and (max-width: 1023px) {
  .description {
    width: 30vw;
  }
}

.data-visor {
  grid-area: data;
}

.data {
  width: 220px;
  height: 170px;
  border-radius: 10px;
  margin-left: 15px;
  display: grid;
  grid-template-areas: "visor visor visor girar" "visor visor visor shine" "visor visor visor ligar" ". anterior proximo procurar";
  gap: 10px;
  grid-template-columns: 2fr 1fr 1fr 1fr;
  grid-template-rows: 1fr 1fr 1fr 1fr;
}
@media (max-width: 767px) {
  .data {
    width: 30vw;
    grid-template-areas: "visor visor visor" "girar shine ligar" "anterior proximo procurar ";
    grid-template-columns: 1fr 1fr 1fr;
    grid-template-rows: 4fr 30px 30px;
  }
}

.vi {
  background-color: #171616;
  border-radius: 10px;
  grid-area: visor;
  overflow-y: hidden;
  overflow-x: hidden;
  padding: 5px;
}

.girar {
  grid-area: girar;
}

.shine {
  grid-area: shine;
}

.ligar {
  grid-area: ligar;
}

.anterior {
  grid-area: anterior;
}

.proximo {
  grid-area: proximo;
}

.procurar {
  grid-area: procurar;
}

.content_visor_principal {
  width: 75%;
  height: 80%;
  background-color: #d1d9e0;
  border: 3px solid rgb(115.1686746988, 121, 126.8313253012);
  border-radius: 10px;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  padding-bottom: 20px;
}
@media (max-width: 767px) {
  .content_visor_principal {
    width: 70vw;
  }
}
@media (min-width: 768px) and (max-width: 1023px) {
  .content_visor_principal {
    width: 65vw;
  }
}

.box_icons_top {
  width: 160px;
  height: 32.5px;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  flex-direction: row;
}

.led_visor {
  width: 8px;
  height: 8px;
  background-color: #545454;
  box-shadow: 1px 1px 5px 0.5px rgba(36, 36, 36, 0.6666666667);
  border-radius: 50%;
  margin: 10px;
}
@media (max-width: 767px) {
  .led_visor {
    display: none;
  }
}
@media (min-width: 768px) and (max-width: 1023px) {
  .led_visor {
    display: none;
  }
}

.box_pokemon_data {
  width: 70%;
  height: 300px;
  background-color: #171616;
  box-shadow: inset 1px 0px 15px 5px rgba(16, 16, 16, 0.7411764706);
  border: 2px solid rgba(72, 72, 72, 0.7411764706);
  border-radius: 10px;
  padding: 10px;
}
@media (max-width: 767px) {
  .box_pokemon_data {
    width: 45vw;
  }
}
@media (min-width: 768px) and (max-width: 1023px) {
  .box_pokemon_data {
    width: 45vw;
  }
}

.table_pokemon {
  width: 100%;
  height: auto;
  display: flex;
  flex-direction: column;
}

.cabecalho {
  margin: 10px;
  display: flex;
  flex-direction: row;
  justify-content: space-around;
}
@media (max-width: 767px) {
  .cabecalho {
    flex-direction: column-reverse;
    justify-content: flex-start;
    align-items: center;
  }
}

.poke_titulo {
  min-width: 80px;
}
@media (max-width: 767px) {
  .poke_titulo p {
    text-align: center;
  }
}

.poke_titulo_img {
  width: 18px;
}

.img_shine {
  width: 15px;
  height: 15px;
  visibility: hidden;
}

.body {
  display: flex;
  flex-direction: column;
}

.tipo {
  width: 100%;
  height: auto;
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: center;
}
.tipo div:first-child {
  margin-right: 10px;
}
@media (max-width: 767px) {
  .tipo {
    flex-direction: column;
  }
}
@media (min-width: 768px) and (max-width: 1023px) {
  .tipo {
    flex-direction: column;
  }
}

.div_poke {
  width: 100%;
  height: 150px;
  position: relative;
  display: flex;
  justify-content: center;
}
@media (max-width: 767px) {
  .div_poke img {
    width: 165px;
    height: 165px;
  }
}

.img_pokemon {
  width: 220px;
  height: 220px;
}
@media (max-width: 767px) {
  .img_pokemon {
    width: 165px;
    height: 165px;
  }
}

.box_icons_bot {
  width: 300px;
  height: 32.5px;
  display: flex;
  flex-direction: row;
  justify-content: space-between;
}
@media (max-width: 767px) {
  .box_icons_bot {
    width: 45vw;
  }
}
@media (min-width: 768px) and (max-width: 1023px) {
  .box_icons_bot {
    width: 45vw;
  }
}

.icons_bot_left {
  width: 110px;
  height: 32.5px;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  align-items: flex-start;
}

.icon_bot {
  width: 10px;
  height: 10px;
  box-shadow: 0px 0px 0px 0.5px rgb(11, 11, 11);
  border-radius: 50%;
  background: radial-gradient(farthest-corner at 4px 4px, #a04646 0%, #6e2121 50%, #4b1212 100%);
}

.icon_bot_on {
  width: 10px;
  height: 10px;
  box-shadow: 0px 0px 0px 0.5px rgb(11, 11, 11), 0px 0px 5px 1px rgba(210, 46, 46, 0.8235294118);
  border-radius: 50%;
  background: radial-gradient(farthest-corner at 4px 4px, #ff4747 0%, #b81e1e 50%, #710808 100%);
}

.icons_bot_right {
  width: 50px;
  height: 32.5px;
  display: flex;
  flex-direction: column;
  align-items: flex-end;
  justify-content: center;
}

.icon_audio {
  width: 25px;
  height: 4px;
  background-color: #3e3e3e;
  border-radius: 5px;
  box-shadow: inset 0px 0px 5px 1px rgb(11, 11, 11);
  margin: 1px;
}

.content_left_border {
  display: none;
}

.btn_descricao {
  width: 35px;
  height: 35px;
  margin: 5px;
  text-align: center;
  border-radius: 5px;
  transition: 0.5s;
  border: none;
  position: relative;
  background-color: rgb(232, 229, 229);
  box-shadow: 0 4px 0 #7e7c7c, 0 4.5px 0 rgba(71, 5, 10, 0.896), 0 5px 1px 1px rgba(71, 5, 10, 0.896), 0 1px 10px 1px rgb(87, 7, 15);
  top: 0px;
  transition: 0.2s;
}
@media (max-width: 767px) {
  .btn_descricao {
    width: 25px;
    height: 25px;
  }
}

.btn_descricao img {
  width: 15px;
  height: 15px;
  margin-top: 2px;
  margin-left: -1px;
  filter: opacity(40%);
}

.btn_descricao:hover {
  top: 2px;
  cursor: pointer;
  box-shadow: 0 2px 0 rgb(115.1686746988, 121, 126.8313253012), 0 4px 3px 1px rgba(71, 5, 10, 0.896), 0 1px 15px 1px rgb(87, 7, 15);
  transition: 0.2s;
}

.btn_ligar {
  width: 35px;
  height: 35px;
  margin-top: 5px;
  margin-left: 5px;
  text-align: center;
  border-radius: 50%;
  background-color: #ebebeb;
  border: none;
  transition: 0.5s;
  position: relative;
  border-radius: 50%;
  border: 0px;
  box-shadow: 0 4px 0 rgb(115.1686746988, 121, 126.8313253012), 0 4.5px 0 rgba(71, 5, 10, 0.896), 0 5px 1px 1px rgba(71, 5, 10, 0.896), 0 1px 10px 1px rgb(87, 7, 15);
  top: 0px;
  transition: 0.2s;
}
@media (max-width: 767px) {
  .btn_ligar {
    width: 30px;
    height: 30px;
    margin-top: 0px;
    margin-left: 0px;
  }
}
@media (min-width: 768px) and (max-width: 1023px) {
  .btn_ligar {
    width: 35px;
    height: 35px;
    margin-left: 5px;
  }
}

.btn_ligar img {
  width: 15px;
  height: 15px;
  margin-top: 2px;
  margin-left: -1px;
  filter: opacity(40%);
}

.btn_ligar:hover {
  top: 2px;
  cursor: pointer;
  box-shadow: 0 2px 0 rgb(115.1686746988, 121, 126.8313253012), 0 4px 3px 1px rgba(71, 5, 10, 0.896), 0 1px 15px 1px rgb(87, 7, 15);
  transition: 0.2s;
}

.poke_btn {
  width: 35px;
  height: 35px;
  background-color: #ebebeb;
  color: rgb(11, 11, 11);
  border-radius: 5px;
}

.poke_btn img {
  width: 20px;
  height: 20px;
  filter: opacity(70%);
}

.poke_btn:hover {
  cursor: pointer;
}

.caixa_indice {
  width: 45px;
  height: 40px;
  background: linear-gradient(308deg, rgb(115.1686746988, 121, 126.8313253012), #ebebeb, #a8acb0);
  border-radius: 5px;
  border: none;
  outline: none;
  margin-right: 10px;
  text-align: center;
}
@media (max-width: 767px) {
  .caixa_indice {
    width: 40px;
    height: 40px;
  }
}

.box_indice {
  display: flex;
  flex-direction: column;
  align-items: center;
}
@media (max-width: 767px) {
  .box_indice {
    width: 40px;
    height: 40px;
  }
}

.btn_poke_pesquisa {
  width: 45px;
  height: 10px;
  border: none;
  border: 1.5px solid rgb(115.1686746988, 121, 126.8313253012);
  border-radius: 25px;
  margin-top: 2px;
  margin-right: 10px;
  box-shadow: 1px 1px 5px 1px rgb(87, 7, 15);
}
@media (max-width: 767px) {
  .btn_poke_pesquisa {
    width: 40px;
    margin-left: 0px;
  }
}

.btn_poke_pesquisa:hover {
  cursor: pointer;
}

.dados_poke_title {
  width: 100px;
  height: 5px;
  padding: 15px;
  font-size: 15px;
}

.dados_poke_sub {
  width: 100px;
  height: 10px;
  font-size: 12px;
  color: rgb(115.1686746988, 121, 126.8313253012);
  padding-left: 15px;
}

.dados_poke {
  width: 100px;
  height: 5px;
  font-size: 12px;
  padding-top: 12px;
  padding-left: 15px;
}

/*# sourceMappingURL=main.cs.map */
