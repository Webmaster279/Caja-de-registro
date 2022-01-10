/*
 * Created by SharpDevelop.
 * User: rutha
 * Date: 23/7/2021
 * Time: 2:20 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tienda
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			notifyIcon1.BalloonTipTitle = "Mis Abuelas";
			notifyIcon1.ShowBalloonTip(3000, "Mis Abuelas | By Revenge®", "Bievenido Patron Nestor.", ToolTipIcon.Info);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//Lista de Productos
		double arrozCristal = 0.92, arrozEmi = 0.92, arrozLlanoVerde = 0.86, lentejas = 1.00, azucar = 1.22, azucarMedioKilo = 0.53, papelon = 0.50, nelly250gr = 0.82, nelly500gr = 1.65,
		                      harinaPanBlanca = 1.10, harinaPanAmarilla = 1.10, harinaPanArroz = 0.98,
		                      kalyBlanca = 0.95, kalyAmarilla = 0.88, harinaTrigoFina = 1.03, HarinaTrigoDonaMaria = 1.03,
		                      harinaBonSabor = 0.91, lecheDoBom120 = 0.75, lecheDoBom200 = 1.20, lecheDoBom400 = 2.35, lecheLiquida = 1.30, lecheCondensada = 1.91,
		                      pastaCapri1Kg = 1.39, pastamedioKilo = 0.71, cafe100grAnzoategui = 0.64,
		                      cafeFlorDeArauca200Gr = 1.20, cafeFlorDeArauca500Gr = 2.86, cafeNonna = 0.65,
		                      cafeBuenCafe250Gr = 1.83, cafeBuenCafe500Gr = 3.22, cafeBuenCafe100Gr = 0.73,
		                      cafeSanSalvador200Gr = 1.20, cafeSanSalvador500Gr = 2.86, cafeSelloRojo250Gr = 2.90,
		                      quesoBlanco = 1.62, quesoAmarillo = 8.80, salchicha = 0.13, jamonAhumado = 8.00,
		                      chuletaAhumada = 9.00, mortadela400Gr = 1.15, mortadela1Kg = 2.25, mortadelaTapara = 9.00,
		                      mortadelaFiesta500Gr = 1.60, jamonItalico1Kg = 5.00,
		                      sal1Kg = 0.40, salMedioKg = 0.21, huevoCarton = 4.10, huevoMedioCarton = 2.05, huevoUnidad = 0.14,
		                      lavaplatosAlisson = 0.73, lavaplatosAxion = 0.68, jabonAzul = 0.60, benteVi = 0.72, ace = 1.90,
		                      esponjayBrillo = 0.21, cloro = 0.60, desinfectante = 0.60, jabonLiquido = 0.62, plagatos = 0.60,
		                      champuSobre = 0.27, acondicionadorSobre = 0.17, hojilla = 0.24,
		                      papelRosal2Rollos = 0.50, papelRosal1Rollo = 0.25, afeitadoras = 0.30, toallasSigloDia = 0.69,
		                      papelSutil4Rollos = 1.12, jabonSupremoRopa = 0.78, lavaPlatosSupremo = 1.15, multiusoSupremo = 0.38,
		                      lavarSupremo = 0.83,
		                      cremaDentalAlident = 0.57, cremaDentalSiglo = 0.46,
		                      jabonDebaños = 0.37, desodoranteHombreMujer = 0.25, desodorante = 0.40, nutribela = 0.47,
		                      acetominofen = 0.10, diclofenac = 0.10, ibuprofeno = 0.11,
		                      bombillo = 0.27, velas = 0.20, yesquero = 0.26, chupichupi = 0.12, aceite = 2.27,
		                      salsaBolonesa = 1.40, salsaPizza = 1.30, salsaHiervasFinas = 1.30,
		                      glup2Litros = 1.37, glup1Litro = 0.73, pepsiLitroyMedio = 1.50, vitaTea = 0.80, fructus = 0.13,
		                      salsaTomatepeqKiero = 0.80, salsaTomateKampist = 1.20, salsaTomateQuidy = 1.20,
		                      mayonesaKiero = 0.39, mayonesaQuiky180Gr = 1.00, mayonesaQuiky445Gr = 2.00,
		                      mayonesaKraff = 2.40, jugo1Litro = 1.40,
		                      mostazaQuidy = 1.12, salsasQuidy = 0.70, 
		                      ajoMixtoComino = 0.18, pimienta = 0.18,
		                      adobo = 0.17, bicarbonato = 0.15, onoto = 0.18, cubito = 0.14, manzanilla = 0.20,
		                      levaduraOPolvodeHornear = 0.22, sopaMaggue = 0.87, canelaEnRama = 0.26, canelaEnPolvo = 0.22,
		                      maizDeCotufa = 0.80, deline250gr = 0.66, deline500gr = 1.35, atun = 1.09, sardina = 0.65, sardinaSalsaItaliana = 0.66,
		                      maizoritospeque = 0.44, cerelac100Gr = 1.30, cremaDeArroz450Gr = 0.60, cremaDeArroz200Gr = 0.33, avenaAvelina = 1.18, fororo = 0.66,
		                      tabaco = 0.16, cigarro = 0.10, chimoCorsel = 0.44, chinata = 0.30,
		                      pepitoTrisGrande = 0.95, cheesTrisGrande = 1.00, doritoMega = 2.10, palomitasAcarame = 0.28,
		                      tabletaDulceDeLeche = 0.42, ticos = 0.31, lokinos = 0.11, oreo = 0.37, blockFresa = 0.28,
		                      blockChocolate = 0.42, tocineta = 0.37, golpe = 0.46, krakeryHony = 0.26, gMaria = 0.17,
		                      clubSocial = 0.22, chupeta = 0.15, chocolates = 0.74, cheetos = 0.41,
		                      lena = 1.50, pegaLoca = 0.24, ron = 2.50, panales = 0.27, cucurma = 0.20, laurel = 0.20,
		                      panSandwichBlanco500gr = 1.87 + 0.20, panSandwichBlanco750gr = 2.63 + 0.20,
		                      panSandwichIntegral500gr = 2.20, panSandwichIntegral750gr = 2.83 + 0.20,
		                      panIntegralPanyPasas650gr = 2.83 + 0.20, hamburguesa4unidades350Grs = 1.95 + 0.20,
		                      hamburguesa8unidades350Grs = 1.95 + 0.20, panPerroCaliente10unidades350gr = 1.95 + 0.20,
		                      panDulceDany500gr = 1.46 + 0.20, panAndinoDonWin500gr = 1.95 + 0.20,
		                      panArabe5Unidades350gr = 1.20 + 0.20, panArabelIntegral5Unidades350gr = 1.28 + 0.20,
		                      acemitas12Unidades600gr = 1.53 + 0.20, cachitos12unidades600gr = 1.98 + 0.20,
		                      panCampesino500gr = 1.38 + 0.20, retornable125 = 0.98, surtidos1LT = 0.90,
		                      cocaCola150 = 1.56, pepitopeque = 0.42, cheeseTrispeque = 0.46,
		                      nutribella = 0.47, harinaTita = 1.09, doritosGrandes = 1.30, doritoPequeno = 0.54,
		                      rufflesPequeno = 0.61, ruffles = 2.15, rufflesGrandes = 4.25, caramelos = 0.04, tandy = 0.19, avelina = 0.24, always = 0.73,
		                      jabonRojex = 0.58, refrescopequeno = 0.55, jamonAhumadoArepero = 8.41,
		                      guisantesyZanahorias = 0.99, maizDulce = 1.03, vinagre = 0.73, maizyGuisantes = 1.02,
		                      galletaMariaPaquete = 0.85, galletaMariaUnidad = 0.19, platanitosNatuchip = 0.99,
		                      takita = 0.85, natuchip150Gr = 1.85, platanitoPeque = 0.55, rosquisPeque = 0.45,
		                      compota = 0.95, rosquisGrandes = 1.35, flaquito = 0.62, salsaBBQ = 0.83,
		                      salsaDeTomateTQF = 1.25, diablitos = 1.00, cremaDeLeche = 1.92, guayabita = 0.23,
		                      pastaDeTomate = 0.82, picante = 0.70, natuchipAjoyPerejil = 1.16, galletaDeSoda = 0.22,
		                      taky = 0.50, tosticos = 1.45, chocolateDucream = 0.19, carneDeGuisaryMolida = 3.67, carneBistek = 3.80,
		                      gelatinaHeinz = 1.00, cacao50Gr = 0.57, cacao100Gr = 1.15, superior = 3.50, papitasDePerro = 0.69,
		                      chocolatinoQuattro = 0.35, galletasStar = 0.35, starWafer = 0.56, sandwichElegante = 0.56,
		                      galletasDeMantequilla = 0.60, galletasMerechal = 0.25, nestum50Gr = 0.59;
		                      
		double resultado, resultado2, resultado3, resultado4, resultado5, resultado6, resultado7, resultado8, resultado9,
		       resultado10, resultado11, resultado12, resultado13, resultado14, resultado15, resultado16, resultado17,
		       resultado18, resultado19, resultado20, resultado21, resultado22, resultado23, resultado24,
		       resultado25, resultado26, resultado27, resultado28, resultado29, resultado30, resultado31,
		       resultado32, resultado33, resultado34, resultado35, resultado36, resultado37, resultado38,
		       resultado39, resultado40;
		
		void BtActualizarClick(object sender, EventArgs e)
		{
			
		}
		void BtBuscarClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
			   if(textBuscar.Text.Equals("arroz cristal") || textBuscar.Text.Equals("Arroz cristal") || textBuscar.Text.Equals("001"))
			   {
				
				resultado = precioDolar * arrozCristal;
				MessageBox.Show("Arroz Cristal: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("arroz emi") || textBuscar.Text.Equals("Arroz emi") || textBuscar.Text.Equals("002"))
			   {
				
				resultado = precioDolar * arrozEmi;
				MessageBox.Show("Arroz Emi: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("lentejas") || textBuscar.Text.Equals("Lentejas") || textBuscar.Text.Equals("003"))
			   {
				
				resultado = precioDolar * lentejas;
				MessageBox.Show("Lentejas: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("azucar") || textBuscar.Text.Equals("Azucar") || textBuscar.Text.Equals("004"))
			   {
				
				resultado = precioDolar * azucar;
				MessageBox.Show("Azucar: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("nelly 250") || textBuscar.Text.Equals("Nelly 250") || textBuscar.Text.Equals("005"))
			   {
				
				resultado = precioDolar * nelly250gr;
				MessageBox.Show("Nelly 250GR: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("nelly 500") || textBuscar.Text.Equals("Nelly 500") || textBuscar.Text.Equals("006"))
			   {
				
			   	resultado = precioDolar * nelly500gr;
				MessageBox.Show("Nelly 500GR: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("harina pan blanca") || textBuscar.Text.Equals("Harina pan blanca") || textBuscar.Text.Equals("007"))
			   {
				
			   	resultado = precioDolar * harinaPanBlanca;
				MessageBox.Show("Harina Pan Blanca: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("harina pan amarilla") || textBuscar.Text.Equals("Harina pan amarilla") || textBuscar.Text.Equals("008"))
			   {
				
			   	resultado = precioDolar * harinaPanAmarilla;
				MessageBox.Show("Harina Pan Amarilla: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("harina pan arroz") || textBuscar.Text.Equals("Harina pan arroz") || textBuscar.Text.Equals("009"))
			   {
				
			   	resultado = precioDolar * harinaPanArroz;
				MessageBox.Show("Harina Pan Arroz: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("kaly blanca") || textBuscar.Text.Equals("Kaly Blanca") || textBuscar.Text.Equals("010"))
			   {
				
			   	resultado = precioDolar * kalyBlanca;
				MessageBox.Show("Kaly Blanca: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("kaly amarilla") || textBuscar.Text.Equals("Kaly amarilla") || textBuscar.Text.Equals("011"))
			   {
				
			   	resultado = precioDolar * kalyAmarilla;
				MessageBox.Show("Kaly Amarilla: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("harina trigo fina") || textBuscar.Text.Equals("Harina trigo fina") || textBuscar.Text.Equals("012"))
			   {
				
			   	resultado = precioDolar * harinaTrigoFina;
				MessageBox.Show("Harina trigo Fina: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("harina trigo doña maria") || textBuscar.Text.Equals("Harina trigo doña maria") || textBuscar.Text.Equals("013"))
			   {
				
			   	resultado = precioDolar * HarinaTrigoDonaMaria;
				MessageBox.Show("Harina trigo Doña Maria: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("harina bon sabor") || textBuscar.Text.Equals("Harina bon sabor") || textBuscar.Text.Equals("014"))
			   {
				
			   	resultado = precioDolar * harinaBonSabor;
				MessageBox.Show("Harina Bon Sabor: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("leche dobom 120") || textBuscar.Text.Equals("Leche dobom 120") || textBuscar.Text.Equals("015"))
			   {
				
			   	resultado = precioDolar * lecheDoBom120;
				MessageBox.Show("Leche Dobom 120GR: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("leche dobom 200") || textBuscar.Text.Equals("leche dobom 200") || textBuscar.Text.Equals("016"))
			   {
				
			   	resultado = precioDolar * lecheDoBom200;
				MessageBox.Show("Leche Dobom 200GR: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("leche liquida") || textBuscar.Text.Equals("Leche liquida") || textBuscar.Text.Equals("017"))
			   {
				
			   	resultado = precioDolar * lecheLiquida;
				MessageBox.Show("Leche Liquida: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("leche condensada") || textBuscar.Text.Equals("Leche condensada") || textBuscar.Text.Equals("018"))
			   {
				
			   	resultado = precioDolar * lecheCondensada;
				MessageBox.Show("Leche Condensada: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("pasta capri") || textBuscar.Text.Equals("espaguetis") || textBuscar.Text.Equals("019"))
			   {
				
			   	resultado = precioDolar * pastaCapri1Kg;
				MessageBox.Show("Pasta Capri 1KG Larga: " + resultado + "Bs" + "\nPasta Capri 1KG Corta: " + resultado + "Bs");
					resultado = precioDolar * pastamedioKilo;
				MessageBox.Show("Pasta 1/2 Larga: " + resultado + "Bs" + "\nPasta 1/2 Corta: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("cafe") || textBuscar.Text.Equals("Cafe") || textBuscar.Text.Equals("020"))
			   {
				
			   	resultado = precioDolar * cafe100grAnzoategui;
			   	resultado2 = precioDolar * cafeFlorDeArauca200Gr;
			   	resultado3 = precioDolar * cafeFlorDeArauca500Gr;
			   	resultado4 = precioDolar * cafeBuenCafe250Gr;
			   	resultado5 = precioDolar * cafeBuenCafe500Gr;
			   	resultado6 = precioDolar * cafeSanSalvador200Gr;
			   	resultado7 = precioDolar * cafeSanSalvador500Gr;
			   	
				MessageBox.Show("100Gr Cafe Anzoategui: " + resultado + "Bs" +
			   	                "\n200Gr Cafe Flor De Arauca: " + resultado2 + "Bs" +
			   	                "\n500Gr Cafe Flor De Arauca: " + resultado3 + "Bs" +
			   	                "\n250Gr Cafe Buen Cafe: " + resultado4 + "Bs" +
			   	                "\n500Gr Cafe Buen Cafe: " + resultado5 + "Bs" +
			   	                "\n200Gr Cafe San Salvador: " + resultado6 + "Bs" +
			   	                "\n500Gr Cafe San Salvador: " + resultado7 + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("queso") || textBuscar.Text.Equals("Queso") || textBuscar.Text.Equals("021"))
			   {
				
			   	resultado = precioDolar * quesoBlanco;
			   	resultado2 = precioDolar * quesoAmarillo;
			   	
				MessageBox.Show("1KG Queso Blanco: " + resultado + "Bs" +
			   	                "\n1KG Queso Amarillo: " + resultado2 + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("salchicha") || textBuscar.Text.Equals("Salchicha") || textBuscar.Text.Equals("022"))
			   {
				
			   	resultado = precioDolar * salchicha;
				MessageBox.Show("Salchicha C/U: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("jamon ahumado") || textBuscar.Text.Equals("Jamon ahumado") || textBuscar.Text.Equals("023"))
			   {
				
			   	resultado = precioDolar * jamonAhumado;
				MessageBox.Show("Jamon Ahumado: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("chuleta ahumada") || textBuscar.Text.Equals("Chuleta ahumada") || textBuscar.Text.Equals("024"))
			   {
				
			   	resultado = precioDolar * chuletaAhumada;
				MessageBox.Show("Chuleta Ahumada: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("mortadela") || textBuscar.Text.Equals("Mortadela") || textBuscar.Text.Equals("025"))
			   {
				
			   	resultado = precioDolar * mortadela400Gr;
			   	resultado2 = precioDolar * mortadela1Kg;
			   	resultado3 = precioDolar * mortadelaTapara;
				MessageBox.Show("400GR Mortadela: " + resultado + "Bs" +
			   	                "\n1KG Mortadela: " + resultado2 + "Bs" +
			   	                "\nMortadela Tapara: " + resultado3 + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("sal") || textBuscar.Text.Equals("Sal") || textBuscar.Text.Equals("026"))
			   {
				
			   	resultado = precioDolar * sal1Kg;
			   	resultado2 = precioDolar * salMedioKg;
				MessageBox.Show("1KG de Sal: " + resultado + "Bs" +
			   	                "\n1/2 de Sal: " + resultado2 + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("huevos") || textBuscar.Text.Equals("huevo") || textBuscar.Text.Equals("027"))
			   {
				
			   	resultado = precioDolar * huevoCarton;
			   	resultado2 = precioDolar * huevoMedioCarton;
			   	resultado3 = precioDolar * huevoUnidad;
				MessageBox.Show("Carton de Huevo: " + resultado + "Bs" +
			   	                "\n1/2 de Huevo: " + resultado2 + "Bs" +
			   	                "\nHuevo C/U: " + resultado3 + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("limpieza") || textBuscar.Text.Equals("Limpieza") || textBuscar.Text.Equals("028"))
			   {
				
			   	resultado = precioDolar * lavaplatosAlisson;
			   	resultado2 = precioDolar * lavaplatosAxion;
			   	resultado3 = precioDolar * jabonAzul;
			   	resultado4 = precioDolar * benteVi;
			   	resultado5 = precioDolar * esponjayBrillo;
			   	resultado6 = precioDolar * cloro;
			   	resultado7 = precioDolar * desinfectante;
			   	resultado8 = precioDolar * jabonLiquido;
			   	
				MessageBox.Show("Lava Platos Alisson: " + resultado + "Bs" +
			   	                "\nLava Platos Axion: " + resultado2 + "Bs" +
			   	                "\nJabon Azul: " + resultado3 + "Bs" +
			   	                "\nBente Vi: " + resultado4 + "Bs" +
			   	                "\nEsponjas y Brillos: " + resultado5 + "Bs" +
			   	                "\nCloro: " + resultado6 + "Bs" +
			   	                "\nDesinfectante: " + resultado7 + "Bs" +
			   	                "\nJabon Liquido: " + resultado8 + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("personal") || textBuscar.Text.Equals("uso personal") || textBuscar.Text.Equals("029"))
			   {
				
			   	resultado = precioDolar * champuSobre;
			   	resultado2 = precioDolar * acondicionadorSobre;
			   	resultado3 = precioDolar * hojilla;
			   	resultado4 = precioDolar * papelRosal1Rollo;
			   	resultado5 = precioDolar * papelRosal2Rollos;
			   	resultado6 = precioDolar * afeitadoras;
			   	resultado7 = precioDolar * cremaDentalAlident;
			   	resultado8 = precioDolar * cremaDentalSiglo;
			   	resultado9 = precioDolar * jabonDebaños;
			   	resultado10 = precioDolar * nutribela;
			   	
				MessageBox.Show("Champu de Sobre: " + resultado + "Bs" +
			   	                "\nAcondicionador de Sobre: " + resultado2 + "Bs" +
			   	                "\nAcondicionador Nutribela: " + resultado10 + "Bs" +
			   	                "\nHojillas C/U: " + resultado3 + "Bs" +
			   	                "\nPapel Rosal 1 Rollo: " + resultado4 + "Bs" +
			   	                "\nPapel Rosal 2 Rollo: " + resultado5 + "Bs" +
			   	                "\nAfeitadoras C/U: " + resultado6 + "Bs" +
			   	                "\nCrema Dental Alident: " + resultado7 + "Bs" +
			   	                "\nCrema Dental Siglo: " + resultado8 + "Bs" +
			   	                "\nJabon Harmony: " + resultado9 + "Bs" +
			   	                "\nJabon Anita: " + resultado9 + "Bs" +
			   	                "\nJabon Avena: " + resultado9 + "Bs" +
			   	                "\nJabon Los Llanos: " + resultado9 + "Bs");
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("jabon") || textBuscar.Text.Equals("jabon de baño") || textBuscar.Text.Equals("030"))
			   {
				
			   	resultado = precioDolar * jabonDebaños;
				MessageBox.Show("Jabon Harmony: " + resultado + "Bs" +
			   	                "\nJabon Anita: " + resultado + "Bs" +
			   	                "\nJabon Avena: " + resultado + "Bs" +
			   	                "\nJabon Los Llanos: " + resultado + "Bs");
				
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("desodorante") || textBuscar.Text.Equals("desodorantes") || textBuscar.Text.Equals("031"))
			   {
				
			   	resultado = precioDolar * desodoranteHombreMujer;
			   	resultado2 = precioDolar * desodorante; 
				MessageBox.Show("Desodorante de sobre Hombre: " + resultado + "Bs" +
			   	                "\nDesodorante de sobre Mujer: " + resultado + "Bs" +
			   	                "\nDesodorante: " + resultado2 + "Bs");
				
				textBuscar.Text = "";
			   }
			   else if(textBuscar.Text.Equals("medicamento") || textBuscar.Text.Equals("medicinas") || textBuscar.Text.Equals("032"))
			   {
				
			   	resultado = precioDolar * acetominofen;
			   	resultado2 = precioDolar * diclofenac;
			   	resultado3 = precioDolar * ibuprofeno;
				MessageBox.Show("Acetominofen C/U: " + resultado + "Bs" +
			   	                "\nDiclofenac C/U: " + resultado2 + "Bs" +
			   	                "\nIbuprofeno C/U: " + resultado3 + "Bs");
				
				textBuscar.Text = "";
			   }
			   if(textBuscar.Text.Equals("bombillo") || textBuscar.Text.Equals("bombillos") || textBuscar.Text.Equals("033"))
			   {
				
				resultado = precioDolar * bombillo;
				MessageBox.Show("Bombillos C/U: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   if(textBuscar.Text.Equals("vela") || textBuscar.Text.Equals("velas") || textBuscar.Text.Equals("034"))
			   {
				
				resultado = precioDolar * velas;
				MessageBox.Show("Velas C/U: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   if(textBuscar.Text.Equals("yesqueros") || textBuscar.Text.Equals("yesquero") || textBuscar.Text.Equals("035"))
			   {
				
				resultado = precioDolar * yesquero;
				MessageBox.Show("Yesqueros C/U: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   if(textBuscar.Text.Equals("chupichupi") || textBuscar.Text.Equals("chupi chupi") || textBuscar.Text.Equals("036"))
			   {
				
				resultado = precioDolar * chupichupi;
				MessageBox.Show("Chupi Chupi C/U: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   if(textBuscar.Text.Equals("aceite") || textBuscar.Text.Equals("aceites") || textBuscar.Text.Equals("037"))
			   {
				
				resultado = precioDolar * aceite;
				MessageBox.Show("Aceites C/U: " + resultado + "Bs");
				textBuscar.Text = "";
			   }
			   if(textBuscar.Text.Equals("salsa") || textBuscar.Text.Equals("salsas") || textBuscar.Text.Equals("038"))
			   {
				
				resultado = precioDolar * salsaBolonesa;
				resultado2 = precioDolar * salsaPizza;
				resultado3 = precioDolar * salsaHiervasFinas;
				resultado4 = precioDolar * salsaTomatepeqKiero;
				resultado5 = precioDolar * salsaTomateKampist;
				resultado6 = precioDolar * salsaTomateQuidy;
				resultado7 = precioDolar * mayonesaKiero;
				resultado8 = precioDolar * mayonesaQuiky180Gr;
				resultado9 = precioDolar * mayonesaQuiky445Gr;
				resultado10 = precioDolar * mostazaQuidy;
				resultado11 = precioDolar * salsasQuidy;
				MessageBox.Show("Salsas de Cocina\n" +
				                "\nSalsa Bolonesa Ole C/U: " + resultado + "Bs" +
				                "\nSalsa Pizza Ole C/U: " + resultado2 + "Bs" +
				                "\nSalsa Hierva Fina Ole C/U: " + resultado3 + "Bs\n----------------------------------\nSalsas de Tomate\n" +
				                "\nSalsa de Tomate Kiero C/U: " + resultado4 + "Bs" +
				                "\nSalsa de Tomate Kampist C/U: " + resultado5 + "Bs" +
				                "\nSalsa de Tomate Quidy C/U: " + resultado6 + "Bs\n----------------------------------\nMayonesas\n" +
				                "\nMayonesa Kiero C/U: " + resultado7 + "Bs" +
				                "\nMayonesa Quidy 180Gr C/U: " + resultado8 + "Bs" +
				                "\nMayonesa Quidy 445Gr C/U: " + resultado9 + "Bs\n----------------------------------\nMostazas\n" +
				                "\nMostaza Quidy C/U: " + resultado10 + "Bs\n----------------------------------\nSalsas para Guisos\n" +
				                "\nSalsa de Ajo Quidy C/U: " + resultado11 + "Bs" +
				                "\nSalsa Inglesa Quidy C/U: " + resultado11 + "Bs" +
				                "\nSalsa de Soya Quidy C/U: " + resultado11 + "Bs");
				textBuscar.Text = "";
			   }
			   if(textBuscar.Text.Equals("refrescos") || textBuscar.Text.Equals("jugos") || textBuscar.Text.Equals("039"))
			   {
				
				resultado = precioDolar * glup2Litros;
				resultado2 = precioDolar * pepsiLitroyMedio;
				resultado3 = precioDolar * vitaTea;
				resultado4 = precioDolar * fructus;
				MessageBox.Show("Refrescos\n" +
				                "\nGlup de 2 Litros C/U: " + resultado + "Bs" +
				                "\nPepsi 1.50 Litros C/U: " + resultado2 + "Bs\n----------------------------------\nJugos\n" +
				                "\nFructus C/U: " + resultado4 + "Bs" +
				                "\nVita Tea C/U: " + resultado3 + "Bs\n----------------------------------");
				textBuscar.Text = "";
			   }
			   if(textBuscar.Text.Equals("condimento") || textBuscar.Text.Equals("condimentos") || textBuscar.Text.Equals("040"))
			   {
				
				resultado = precioDolar * ajoMixtoComino;
				resultado2 = precioDolar * pimienta;
				resultado3 = precioDolar * adobo;
				resultado4 = precioDolar * onoto;
				resultado5 = precioDolar * cubito;
				resultado6 = precioDolar * manzanilla;
				resultado7 = precioDolar * levaduraOPolvodeHornear;
				resultado8 = precioDolar * sopaMaggue;
				resultado9 = precioDolar * canelaEnRama;
				MessageBox.Show("Condimentos\n" +
				                "\nAjo, Ajo Mix, Comino C/U: " + resultado + "Bs" +
				                "\nPimienta, Carmencita C/U: " + resultado2 + "Bs" +
				                "\nAdobo C/U: " + resultado3 + "Bs" +
				                "\nOnoto C/U: " + resultado4 + "Bs" +
				                "\nCubito C/U: " + resultado5 + "Bs" +
				                "\nManzanilla C/U: " + resultado6 + "Bs" +
				                "\nLavadura, Polvo de Hornear C/U: " + resultado7 + "Bs" +
				                "\nSopa Maggue C/U: " + resultado8 + "Bs" +
				                "\nCanela en Rama C/U: " + resultado9 + "Bs\n----------------------------------");
				textBuscar.Text = "";
			   }
			   
			}
			catch(Exception)
			{
				MessageBox.Show("No hay nada en el campo de Dolar.");
			}
		}
		void BtGranosClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * arrozCristal;
				resultado2 = precioDolar * lentejas;
				resultado3 = precioDolar * maizDeCotufa;
				resultado4 = precioDolar * arrozLlanoVerde;
				
				MessageBox.Show("Granos:\n\nArroz Cristal C/U:\t\t" + resultado + "Bs = " + arrozCristal + "$"+
				                "\nArroz Emi C/U:\t\t" + resultado + "Bs = " + arrozEmi + "$"+
				                "\nArroz Llano Verde C/U:\t" + resultado4 + "Bs = " + arrozLlanoVerde + "$"+
				                "\nLentejas C/U:\t\t" + resultado2 + "Bs = " + lentejas + "$"+
				                "\nMaiz de Cotufa C/U:\t" + resultado3 + "Bs = " + maizDeCotufa + "$" + 
				                "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
				
		}
		void BtAzucarClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * azucar;
				resultado2 = precioDolar * azucarMedioKilo;
				resultado3 = precioDolar * papelon;
				MessageBox.Show("Azucar:\n\n1 KG de Azucar C/U:\t" + resultado + "Bs = " + azucar + "$"+
				                "\n1/2 de Azucar C/U:\t\t" + resultado2 + "Bs = " + azucarMedioKilo + "$" +
				                "\nPapelon C/U:\t\t" + resultado3 + "Bs = " + papelon + "$" 
				                + "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtMargarinaClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * deline250gr;
				resultado4 = precioDolar * deline500gr;
				resultado2 = precioDolar * nelly500gr;
				resultado3 = precioDolar * nelly250gr;
				MessageBox.Show("Margarinas:\n\n250Gr Deline C/U:\t" + resultado + "Bs = " + deline250gr + "$" +
				                "\n500Gr Deline C/U:\t" + resultado4 + "Bs = " + deline500gr + "$" +
				                "\n500Gr Nelly C/U:\t" + resultado2 + "Bs = " + nelly500gr + "$" +
				                "\n250Gr Nelly C/U:\t" + resultado3 + "Bs = " + nelly250gr + "$" + "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtHarinaTrigoClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * harinaTrigoFina;
				resultado2 = precioDolar * HarinaTrigoDonaMaria;
				resultado3 = precioDolar * harinaBonSabor;
	
				MessageBox.Show("Harina de Trigo:\n\nHarina de Trigo Fina C/U:\t\t" + resultado + "Bs = " + harinaTrigoFina+ "$" +
				                "\nHarina de Trigo Doña Maria C/U:\t" + resultado2 + "Bs = " + HarinaTrigoDonaMaria + "$" +
				                "\nHarina de Trigo Bon Sabor C/U:\t" + resultado3 + "Bs = " + harinaBonSabor + "$" + 
				                "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtHarinaMaizClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * harinaPanAmarilla; //La blanca tiene el mismo precio
				resultado2 = precioDolar * harinaPanArroz;
				resultado3 = precioDolar * kalyBlanca;
				resultado4 = precioDolar * kalyAmarilla;
				resultado5 = precioDolar * harinaTita;
				MessageBox.Show("Harina de Maiz:\n\nHarina Pan Amarilla C/U:\t" + resultado + "Bs = " + harinaPanAmarilla + "$"+
				                "\nHarina Pan Blanca C/U:\t" + resultado + "Bs = " + harinaPanAmarilla + "$" +
				                "\nHarina Pan Arroz C/U:\t" + resultado2 + "Bs = " + harinaPanArroz + "$"+
				                "\nHarina Kaly Blanca C/U:\t" + resultado3 + "Bs = " + kalyBlanca + "$"+
				                "\nHarina Kaly Amarilla C/U:\t" + resultado4 + "Bs = " + kalyAmarilla + "$"+
				                "\nHarina Doña Tita Blanca C/U:\t" + resultado5 + "Bs = " + harinaTita + "$"+ 
				                "\nHarina Doña Tita Amarilla C/U:\t" + resultado5 + "Bs = " + harinaTita + "$"+ 
				                "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtEspaguetisClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * pastaCapri1Kg;
				resultado2 = precioDolar * pastamedioKilo;
				
				MessageBox.Show("Espaguetis:\n\n1KG Pasta Capri Larga C/U:\t" + resultado + "Bs = " + pastaCapri1Kg + "$"+
				                "\n1KG Pasta Capri Corta C/U:\t" + resultado + "Bs = " + pastaCapri1Kg + "$"+
				                "\n1/2KG Pasta Larga C/U:\t" + resultado2 + "Bs = " + pastamedioKilo + "$"+
				                "\n1/2KG Pasta Corta C/U:\t" + resultado2 + "Bs = " + pastamedioKilo + "$"+ "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtLechesClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * lecheDoBom200;
				resultado2 = precioDolar * lecheDoBom120;
				resultado3 = precioDolar * lecheLiquida;
				resultado4 = precioDolar * lecheCondensada;
				resultado5 = precioDolar * lecheDoBom400;
				
				MessageBox.Show("Leches:\n\n200Gr Leche Do Bom C/U:\t" + resultado + "Bs = " + lecheDoBom200 + "$"+
				                "\n120Gr Leche Do Bom C/U:\t" + resultado2 + "Bs = " + lecheDoBom120 + "$"+
				                "\n120Gr Leche Do Bom C/U:\t" + resultado5 + "Bs = " + lecheDoBom400 + "$"+
				                "\nLeche Liquida C/U:\t\t" + resultado3 + "Bs = " + lecheLiquida + "$"+
				                "\nLeche Condensada C/U:\t" + resultado4 + "Bs = " + lecheCondensada + "$" + "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtCafesClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * cafe100grAnzoategui;
				resultado2 = precioDolar * cafeFlorDeArauca500Gr;
				resultado3 = precioDolar * cafeFlorDeArauca200Gr;
				resultado4 = precioDolar * cafeBuenCafe500Gr;
				resultado5 = precioDolar * cafeBuenCafe250Gr;
				resultado8 = precioDolar * cafeBuenCafe100Gr;
				resultado6 = precioDolar * cafeSanSalvador500Gr;
				resultado7 = precioDolar * cafeSanSalvador200Gr;
				resultado9 = precioDolar * cafeSelloRojo250Gr;
				resultado10 = precioDolar * cafeNonna;
				
				MessageBox.Show("Cafes:\n\n100Gr Cafe Anzoategui C/U:\t\t" + resultado + "Bs = " + cafe100grAnzoategui + "$"+
				                "\n500Gr Cafe Flor de Arauca C/U:\t" + resultado2 + "Bs = " + cafeFlorDeArauca500Gr + "$"+
				                "\n200Gr Cafe Flor de Arauca C/U:\t" + resultado3 + "Bs = " + cafeFlorDeArauca200Gr + "$"+
				                "\n500Gr Cafe Buen Cafe C/U:\t\t" + resultado4 + "Bs = " + cafeBuenCafe500Gr + "$"+
				                "\n250Gr Cafe Buen Cafe C/U:\t\t" + resultado5 + "Bs = " + cafeBuenCafe250Gr + "$"+
				                "\n100Gr Cafe Buen Cafe C/U:\t\t" + resultado8 + "Bs = " + cafeBuenCafe100Gr + "$"+
				                "\n500Gr Cafe San Salvador C/U:\t" + resultado6 + "Bs = " + cafeSanSalvador500Gr + "$"+
				                "\n200Gr Cafe San Salvador C/U:\t" + resultado7 + "Bs = " + cafeSanSalvador200Gr + "$"+
				                "\n250Gr Cafe Sello Rojo C/U:\t\t" + resultado9 + "Bs = " + cafeSelloRojo250Gr + "$"+
				                "\nCafe de la Nonna C/U:\t\t" + resultado10 + "Bs = " + cafeNonna + "$"
				                +"\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtEnlatadosClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * atun;
				resultado2 = precioDolar * sardina;
				resultado3 = precioDolar * sardinaSalsaItaliana;
				resultado4 = precioDolar * guisantesyZanahorias;
				resultado5 = precioDolar * maizDulce;
				resultado6 = precioDolar * maizyGuisantes;
				resultado7 = precioDolar * diablitos;
				resultado8 = precioDolar * cremaDeLeche;
				
				MessageBox.Show("Enlatados:\n\nAtun C/U:\t\t" + resultado + "Bs = " + atun + "$"+
				                "\nSardina C/U:\t\t" + resultado2 + "Bs = " + sardina + "$"+
				                "\nSardina Salsa Italiana C/U:\t" + resultado3 + "Bs = " + sardinaSalsaItaliana + "$"+
				                "\nGuisantes y Zanahorias C/U:\t" + resultado4 + "Bs = " + guisantesyZanahorias + "$"+
				                "\nMaiz Dulce C/U:\t" + resultado5 + "Bs = " + maizDulce + "$"+
				                "\nMaiz y Guisantes C/U:\t" + resultado6 + "Bs = " + maizyGuisantes + "$"+
				                "\nDiablitos C/U:\t" + resultado7 + "Bs = " + diablitos + "$"+
				                "\nCrema de Leche C/U:\t" + resultado8 + "Bs = " + cremaDeLeche + "$"+
				                "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtSalClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * sal1Kg;
				resultado2 = precioDolar * salMedioKg;
				
				MessageBox.Show("Sal:\n\n1KG de Sal C/U:\t" + resultado + "Bs = " + sal1Kg + "$"+
				                "\n1/2 de Sal C/U:\t" + resultado2 + "Bs = " + salMedioKg + "$"+"\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtHuevosClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * huevoCarton;
				resultado2 = precioDolar * huevoMedioCarton;
				resultado3 = precioDolar * huevoUnidad;
				
				MessageBox.Show("Huevos:\n\nCarton de Huevos C/U:\t" + resultado + "Bs = " + huevoCarton + "$"+
				                "\n1/2 de Huevos C/U:\t" + resultado2 + "Bs = " + huevoMedioCarton + "$"+
				                "\nHuevos C/U:\t\t" + resultado3 + "Bs = " + huevoUnidad + "$"+"\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtEmbutidosClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * quesoBlanco;
				resultado2 = precioDolar * quesoAmarillo;
				resultado3 = precioDolar * salchicha;
				resultado4 = precioDolar * jamonAhumado;
				resultado5 = precioDolar * chuletaAhumada;
				resultado6 = precioDolar * mortadela1Kg;
				resultado7 = precioDolar * mortadela400Gr;
				resultado8 = precioDolar * mortadelaTapara;
				resultado9 = precioDolar * jamonAhumadoArepero;
				resultado10 = precioDolar * jamonItalico1Kg;
				resultado11 = precioDolar * mortadelaFiesta500Gr;
				resultado12 = precioDolar * carneDeGuisaryMolida;
				resultado13 = precioDolar * carneBistek;
				
				MessageBox.Show("Embutidos:\n\n1Kg de Queso Blanco C/U:\t\t" + resultado + "Bs = " + quesoBlanco + "$"+
				                "\n1Kg de Queso Amarillo C/U:\t\t" + resultado2 + "Bs = " + quesoAmarillo + "$"+
				                "\nSalchichas C/U:\t\t\t" + resultado3 + "Bs = " + salchicha + "$"+
				                "\n1Kg Jamon Ahumado C/U:\t\t" + resultado4 + "Bs = " + jamonAhumado + "$"+
				                "\n1Kg Chuleta Ahumada C/U:\t\t" + resultado5 + "Bs = " + chuletaAhumada + "$"+
				                "\n1Kg Mortadela C/U:\t\t" + resultado6 + "Bs = " + mortadela1Kg + "$"+
				                "\n400Gr Mortadela C/U:\t\t" + resultado7 + "Bs = " + mortadela400Gr + "$"+
				                "\n1Kg Mortadela Tapara C/U:\t\t" + resultado8 + "Bs = " + mortadelaTapara + "$"+
				                "\n1Kg Jamon Ahumado Arepero C/U:\t" + resultado9 + "Bs = " + jamonAhumadoArepero + "$"+
				                "\n1Kg Jamon Italico C/U:\t\t" + resultado10 + "Bs = " + jamonItalico1Kg + "$"+
				                "\n500Gr Mortadela Fiesta C/U:\t" + resultado11 + "Bs = " + mortadelaFiesta500Gr + "$"+
				                "\n----------------------------------------------"+
				                "\n\nCarnes:\n"+
				                "\n Carne de Guisar \t" + resultado12 + "Bs = " + carneDeGuisaryMolida + "$"+
				                "\n Carne Molida \t" + resultado12 + "Bs = " + carneDeGuisaryMolida + "$"+
				                "\n Carne de Bistek \t" + resultado13 + "Bs = " + carneBistek + "$"+
				                "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtEspeciasClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * ajoMixtoComino;
				resultado2 = precioDolar * pimienta; //Carmencita tambien
				resultado3 = precioDolar * adobo;
				resultado4 = precioDolar * bicarbonato;
				resultado5 = precioDolar * onoto;
				resultado6 = precioDolar * cubito;
				resultado7 = precioDolar * manzanilla;
				resultado8 = precioDolar * levaduraOPolvodeHornear;
				resultado9 = precioDolar * sopaMaggue;
				resultado10 = precioDolar * canelaEnRama;
				resultado11 = precioDolar * cucurma;
				resultado12 = precioDolar * laurel;
				resultado13 = precioDolar * canelaEnPolvo;
				resultado14 = precioDolar * guayabita;
				
				MessageBox.Show("Condimentos y Especias:\n\nAjo, Ajo Mix, Comino C/U:\t\t" + resultado + "Bs = " + ajoMixtoComino + "$"+
				                "\nPimienta, Carmencita C/U:\t\t" + resultado2 + "Bs = " + pimienta + "$"+
				                "\nAdobo C/U:\t\t\t" + resultado3 + "Bs = " + adobo + "$"+
				                "\nBicarbonato C/U:\t\t\t" + resultado4 + "Bs = " + bicarbonato + "$"+
				                "\nOnoto C/U:\t\t\t" + resultado5 + "Bs = " + onoto + "$"+
				                "\nCubito C/U:\t\t\t" + resultado6 + "Bs = " + cubito + "$"+
				                "\nManzanilla C/U:\t\t\t" + resultado7 + "Bs = " + manzanilla + "$"+
				                "\nLevadura, Polvo de Hornear C/U:\t" + resultado8 + "Bs = " + levaduraOPolvodeHornear + "$"+
				                "\nSopa Maggie C/U:\t\t\t" + resultado9 + "Bs = " + sopaMaggue + "$"+
				                "\nCanela en Rama C/U:\t\t" + resultado10 + "Bs = " + canelaEnRama + "$"+
				                "\nCurcuma C/U:\t\t\t" + resultado11 + "Bs = " + cucurma + "$"+
				                "\nLaurel C/U:\t\t\t" + resultado12 + "Bs = " + laurel + "$"+
				                "\nCanela en Polvo C/U:\t\t" + resultado13 + "Bs = " + canelaEnPolvo + "$"+
				                "\nGuayabita C/U:\t\t" + resultado14 + "Bs = " + guayabita + "$"+
				                "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtSalsasClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * salsaTomatepeqKiero;
				resultado2 = precioDolar * salsaTomateKampist;
				resultado3 = precioDolar * salsaTomateQuidy;
				resultado4 = precioDolar * mayonesaKiero;
				resultado5 = precioDolar * mayonesaQuiky445Gr;
				resultado6 = precioDolar * mayonesaQuiky180Gr;
				resultado16 = precioDolar * mayonesaKraff;
				resultado7 = precioDolar * mostazaQuidy;
				resultado8 = precioDolar * salsasQuidy;
				resultado9 = precioDolar * aceite;
				resultado10 = precioDolar * salsaBolonesa;
				resultado11 = precioDolar * salsaPizza;
				resultado12 = precioDolar * vinagre;
				resultado13 = precioDolar * salsaDeTomateTQF;
				resultado14 = precioDolar * salsaBBQ;
				resultado15 = precioDolar * pastaDeTomate;
				resultado17 = precioDolar * picante;
				
				MessageBox.Show("Salsas Tomate/Mayonesa/Mostaza/Etc:\n\nSalsa Tomate Pequeña C/U:\t\t" + resultado + "Bs = " + salsaTomatepeqKiero + "$"+
				                "\nSalsa Tomate Kampist C/U:\t\t" + resultado2 + "Bs = " + salsaTomateKampist + "$"+
				                "\nSalsa Tomate Quidy C/U:\t\t" + resultado3 + "Bs = " + salsaTomateQuidy + "$"+
				                "\nSalsa Tomate T.Q.F C/U:\t\t" + resultado13 + "Bs = " + salsaDeTomateTQF + "$"+
				                "\nPasta de Tomate C/U:\t\t" + resultado15 + "Bs = " + pastaDeTomate + "$"+
				                "\nPicante C/U:\t\t\t" + resultado17 + "Bs = " + picante + "$"+
				                "\nSalsa BBQ C/U:\t\t\t" + resultado14 + "Bs = " + salsaBBQ + "$"+
				                "\nMayonesa Quero C/U:\t\t" + resultado4 + "Bs = " + mayonesaKiero + "$"+
				                "\nMayonesa Kraff C/U:\t\t" + resultado16 + "Bs = " + mayonesaKraff + "$"+
				                "\n445Gr Mayonesa Quidy C/U:\t\t" + resultado5 + "Bs = " + mayonesaQuiky445Gr + "$"+
				                "\n180Gr Mayonesa Quidy C/U:\t\t" + resultado6 + "Bs = " + mayonesaQuiky180Gr + "$"+
				                "\nMostaza Quidy C/U:\t\t" + resultado7 + "Bs = " + mostazaQuidy + "$"+
				                "\n\nSalsas OLE\n---------------------\nSalsa Boloñesa C/U:\t\t" + resultado10 + "Bs = " + salsaBolonesa + "$"+
				                "\nSalsa Para Pizzas C/U:\t\t" + resultado11 + "Bs = " + salsaPizza + "$"+
				                "\nSalsa Hierbas Finas C/U:\t\t" + resultado11 + "Bs = " + salsaPizza + "$"+"\n---------------------" +
				                "\nSalsa de Ajo Quidy C/U:\t\t" + resultado8 + "Bs = " + salsasQuidy + "$"+
				                "\nSalsa Inglesa Quidy C/U:\t\t" + resultado8 + "Bs = " + salsasQuidy + "$"+
				                "\nSalsa de Soya Quidy C/U:\t\t" + resultado8 + "Bs = " + salsasQuidy + "$"+
				                "\nAceite de Cocina C/U:\t\t" + resultado9 + "Bs = " + aceite + "$"+
				                "\nVinagre C/U:\t\t\t" + resultado12 + "Bs = " + vinagre + "$"+
				                "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtLimpiezaClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * lavaplatosAlisson;
				resultado2 = precioDolar * lavaplatosAxion;
				resultado3 = precioDolar * jabonAzul;
				resultado4 = precioDolar * benteVi;
				resultado5 = precioDolar * esponjayBrillo;
				resultado6 = precioDolar * cloro;
				resultado7 = precioDolar * desinfectante;
				resultado8 = precioDolar * jabonLiquido;
				resultado9 = precioDolar * plagatos;
				resultado10 = precioDolar * jabonSupremoRopa;
				resultado11 = precioDolar * ace;
				resultado12 = precioDolar * lavaPlatosSupremo;
				resultado13 = precioDolar * multiusoSupremo;
				resultado14 = precioDolar * lavarSupremo;
				//resultado10 = precioDolar * canelaEnRama;
				
				MessageBox.Show("Productos de Limpieza:\n\nLava Platos Alisson C/U:\t\t" + resultado + "Bs = " + lavaplatosAlisson + "$"+
				                "\nLava Platos Axion C/U:\t\t" + resultado2 + "Bs = " + lavaplatosAxion + "$"+
				                "\nJabon Azul C/U:\t\t\t" + resultado3 + "Bs = " + jabonAzul + "$"+
				                "\nBente Vi C/U:\t\t\t" + resultado4 + "Bs = " + benteVi + "$"+
				                "\nEsponja y Brillo C/U:\t\t" + resultado5 + "Bs = " + esponjayBrillo + "$"+
				                "\nCloro C/U:\t\t\t" + resultado6 + "Bs = " + cloro + "$"+
				                "\nDesinfectante C/U:\t\t" + resultado7 + "Bs = " + desinfectante + "$"+
				                "\nJabon Liquido C/U:\t\t" + resultado8 + "Bs = " + jabonLiquido + "$"+
				                "\nPlagatos C/U:\t\t\t" + resultado9 + "Bs = " + plagatos + "$"+
				                "\nJabon Supremo Ropa C/U:\t\t" + resultado10 + "Bs = " + jabonSupremoRopa + "$"+
				                "\nAce C/U:\t\t\t\t" + resultado11 + "Bs = " + ace + "$"+
				                "\nLava Platos Supremo C/U:\t\t" + resultado12 + "Bs = " + lavaPlatosSupremo + "$"+
				                "\nMultiuso Supremo C/U:\t\t" + resultado13 + "Bs = " + multiusoSupremo + "$"+
				                "\nLavar Supremo C/U:\t\t" + resultado14 + "Bs = " + lavarSupremo + "$"+
				                "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtPersonalesClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * champuSobre;
				resultado2 = precioDolar * acondicionadorSobre;
				resultado3 = precioDolar * hojilla;
				resultado4 = precioDolar * papelRosal2Rollos;
				resultado5 = precioDolar * papelRosal1Rollo;
				resultado6 = precioDolar * afeitadoras;
				resultado7 = precioDolar * cremaDentalAlident;
				resultado8 = precioDolar * cremaDentalSiglo;
				resultado9 = precioDolar * toallasSigloDia;
				resultado10 = precioDolar * jabonDebaños;
				resultado11 = precioDolar * desodoranteHombreMujer;
				resultado12 = precioDolar * desodorante;
				resultado13 = precioDolar * panales;
				resultado14 = precioDolar * nutribella;
				resultado15 = precioDolar * always;
				resultado16 = precioDolar * jabonRojex;
				resultado17 = precioDolar * papelSutil4Rollos;
				
				MessageBox.Show("Productos de Uso Personal:\n\nChampu de Sobre C/U:\t\t\t" + resultado + "Bs = " + champuSobre + "$"+
				                "\nAcondicionador de Sobre C/U:\t\t" + resultado2 + "Bs = " + acondicionadorSobre + "$"+
				                "\nHojillas C/U:\t\t\t\t" + resultado3 + "Bs = " + hojilla + "$"+
				                "\nPapel Rosal 2 Rollos C/U:\t\t\t" + resultado4 + "Bs = " + papelRosal2Rollos + "$"+
				                "\nPapel Rosal 1 Rollos C/U:\t\t\t" + resultado5 + "Bs = " + papelRosal1Rollo + "$"+
				                "\nPapel Sutil 4 Rollos C/U:\t\t\t" + resultado17 + "Bs = " + papelSutil4Rollos + "$"+
				                "\nAfeitadoras C/U:\t\t\t\t" + resultado6 + "Bs = " + afeitadoras + "$"+
				                "\nCrema Dental Alident C/U:\t\t\t" + resultado7 + "Bs = " + cremaDentalAlident + "$"+
				                "\nCrema Dental Siglo C/U:\t\t\t" + resultado8 + "Bs = " + cremaDentalSiglo + "$"+
				                "\nToallas Siglo Dia C/U:\t\t\t" + resultado9 + "Bs = " + toallasSigloDia + "$"+
				                "\nSobre Desodorante de Hombre C/U:\t\t" + resultado11 + "Bs = " + desodoranteHombreMujer + "$"+
				                "\nSobre Desodorante de Mujer C/U:\t\t" + resultado11 + "Bs = " + desodoranteHombreMujer + "$"+
				                "\nDesodorante ByK C/U:\t\t\t" + resultado12 + "Bs = " + desodorante + "$"+
				                "\nJabon de Baño C/U:\t\t\t" + resultado10 + "Bs = " + jabonDebaños + "$"+
				                "\nJabon Rojex C/U:\t\t\t" + resultado16 + "Bs = " + jabonRojex + "$"+
				                "\nNutribella C/U:\t\t\t" + resultado14 + "Bs = " + nutribella + "$"+
				                "\nPañales C/U:\t\t\t\t" + resultado13 + "Bs = " + panales + "$" +
				                "\nAlways C/U:\t\t\t\t" + resultado15 + "Bs = " + always + "$" +
				                "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtMedicinasClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * acetominofen;
				resultado2 = precioDolar * diclofenac;
				resultado3 = precioDolar * ibuprofeno;
				
				MessageBox.Show("Medicinas:\n\nAcetominofen C/U:\t" + resultado + "Bs = " + acetominofen + "$"+
				                "\nDiclofenac C/U:\t\t" + resultado2 + "Bs = " + diclofenac + "$"+
				                "\nIbuprofeno C/U:\t\t" + resultado3 + "Bs = " + ibuprofeno + "$"+"\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtCerealesClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * maizoritospeque;
				resultado2 = precioDolar * cerelac100Gr;
				resultado3 = precioDolar * cremaDeArroz450Gr;
				resultado4 = precioDolar * avenaAvelina;
				resultado5 = precioDolar * fororo;
				resultado6 = precioDolar * gelatinaHeinz;
				resultado7 = precioDolar * cremaDeArroz200Gr;
				resultado8 = precioDolar * cacao50Gr;
				resultado9 = precioDolar * cacao100Gr;
				resultado10 = precioDolar * cacao100Gr;
				resultado11 = precioDolar * nestum50Gr;
				
				MessageBox.Show("Cereales:\n\nMaizoritos Pequeño C/U:\t" + resultado + "Bs = " + maizoritospeque + "$"+
				                "\n100Gr Cerelac C/U:\t\t" + resultado2 + "Bs = " + cerelac100Gr + "$"+
				                "\n450Gr Crema de Arroz C/U:\t" + resultado3 + "Bs = " + cremaDeArroz450Gr + "$"+
				                "\n200Gr Crema de Arroz C/U:\t" + resultado7 + "Bs = " + cremaDeArroz200Gr + "$"+
				                "\n450Gr Avena Avelina C/U:\t" + resultado4 + "Bs = " + avenaAvelina + "$"+
				                "\nFororo C/U:\t\t" + resultado5 + "Bs = " + fororo + "$"+
				                "\nGelatina Heinz C/U:\t" + resultado6 + "Bs = " + gelatinaHeinz + "$"+
				                "\n100Gr de Cacao C/U:\t" + resultado9 + "Bs = " + cacao100Gr + "$"+
				                "\n50Gr de Cacao C/U:\t" + resultado8 + "Bs = " + cacao50Gr + "$"+
				                "\n50Gr de Nestum C/U:\t" + resultado11 + "Bs = " + nestum50Gr + "$"+
				                "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtRefrescosClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * glup2Litros;
				resultado2 = precioDolar * pepsiLitroyMedio;
				resultado3 = precioDolar * vitaTea;
				resultado4 = precioDolar * fructus;
				resultado5 = precioDolar * retornable125;
				resultado6 = precioDolar * cocaCola150;
				resultado7 = precioDolar * surtidos1LT;
				resultado8 = precioDolar * refrescopequeno;
				resultado9 = precioDolar * glup1Litro;
				resultado10 = precioDolar * jugo1Litro;
				resultado11 = precioDolar * tandy;
				
				MessageBox.Show("Refrescos y Bebidas:\n\nGlup de 2 Litros C/U:\t" + resultado + "Bs = " + glup2Litros + "$"+
				                "\nGlup de 1.0 Litros C/U:\t" + resultado9 + "Bs = " + glup1Litro + "$"+
				                "\nPepsi Cola 1.5 Litros C/U:\t" + resultado2 + "Bs = " + pepsiLitroyMedio + "$"+
				                "\nRetornable 1.25 Litros C/U:\t" + resultado5 + "Bs = " + retornable125 + "$"+
				                "\nCoca Cola  1.5 Litros C/U:\t" + resultado6 + "Bs = " + cocaCola150 + "$"+
				                "\nSurtidos   1.0 Litros C/U:\t" + resultado7 + "Bs = " + surtidos1LT + "$"+
				                "\nRefresco Pequeño C/U:\t" + resultado8 + "Bs = " + refrescopequeno + "$"+
				                "\nVita Tea C/U:\t\t" + resultado3 + "Bs = " + vitaTea + "$"+
				                "\nFructus C/U:\t\t" + resultado4 + "Bs = " + fructus + "$"+
				                "\nJugo de 1.0 Litros C/U:\t" + resultado10 + "Bs = " + jugo1Litro + "$"+
				                "\nTandy C/U:\t\t" + resultado11 + "Bs = " + tandy + "$"+
				                "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtCigarrosClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * cigarro;
				resultado2 = precioDolar * tabaco;
				resultado3 = precioDolar * chimoCorsel;
				resultado4 = precioDolar * chinata;
				
				MessageBox.Show("Cigarros/Tabacos/Chimo:\n\nCigarros C/U:\t\t" + resultado + "Bs = " + cigarro + "$"+
				                "\nTabaco C/U:\t\t" + resultado2 + "Bs = " + tabaco + "$"+
				                "\nChimo Corsel C/U:\t\t" + resultado3 + "Bs = " + chimoCorsel + "$"+
				                "\nChinata C/U:\t\t" + resultado4 + "Bs = " + chinata + "$"+"\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtChucheriasClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * pepitoTrisGrande;
				resultado2 = precioDolar * cheesTrisGrande;
				resultado3 = precioDolar * doritoMega;
				resultado4 = precioDolar * palomitasAcarame;
				resultado5 = precioDolar * tabletaDulceDeLeche;
				resultado6 = precioDolar * ticos;
				resultado7 = precioDolar * lokinos;
				resultado8 = precioDolar * oreo;
				resultado9 = precioDolar * blockFresa;
				resultado10 = precioDolar * blockChocolate;
				resultado11 = precioDolar * tocineta;
				resultado12 = precioDolar * golpe;
				resultado13 = precioDolar * krakeryHony;
				resultado14 = precioDolar * gMaria;
				resultado15 = precioDolar * clubSocial;
				resultado16 = precioDolar * chupeta;
				resultado17 = precioDolar * chocolates;
				resultado18 = precioDolar * cheetos;
				resultado19 = precioDolar * pepitopeque;
				resultado20 = precioDolar * cheeseTrispeque;
				resultado21 = precioDolar * doritosGrandes;
				resultado22 = precioDolar * doritoPequeno;
				resultado23 = precioDolar * ruffles;
				resultado24 = precioDolar * tandy;
				resultado25 = precioDolar * caramelos;
				resultado26 = precioDolar * avelina;
				resultado27 = precioDolar * galletaMariaPaquete;
				resultado28 = precioDolar * galletaMariaUnidad;
				resultado29 = precioDolar * platanitosNatuchip;
				resultado30 = precioDolar * takita;
				resultado31 = precioDolar * rufflesGrandes;
				resultado32 = precioDolar * natuchip150Gr;
				resultado33 = precioDolar * platanitoPeque;
				resultado34 = precioDolar * rosquisGrandes;
				resultado35 = precioDolar * rosquisPeque;
				resultado36 = precioDolar * compota;
				resultado37 = precioDolar * flaquito;
				
				MessageBox.Show("Chucherias:\n\n Pepito Tris Grande C/U:\t\t\t" + resultado + "Bs = " + pepitoTrisGrande + "$"+
				                "\n Chees Tris Grande C/U:\t\t\t" + resultado2 + "Bs = " + cheesTrisGrande + "$"+
				                "\n Dorito Mega C/U:\t\t\t\t" + resultado3 + "Bs = " + doritoMega + "$"+
				                "\n Palomitas Acarameladas C/U:\t\t" + resultado4 + "Bs = " + palomitasAcarame + "$"+
				                "\n Tableta Dulce De Leche C/U:\t\t" + resultado5 + "Bs = " + tabletaDulceDeLeche + "$"+
				                "\n Ticos C/U:\t\t\t\t" + resultado6 + "Bs = " + ticos + "$"+
				                "\n Lokiños C/U:\t\t\t\t" + resultado7 + "Bs = " + lokinos + "$"+
				                "\n Oreo C/U:\t\t\t\t" + resultado8 + "Bs = " + oreo + "$"+
				                "\n Block Fresa C/U:\t\t\t\t" + resultado9 + "Bs = " + blockFresa + "$"+
				                "\n Block Chocolate C/U:\t\t\t" + resultado10 + "Bs = " + blockChocolate + "$"+
				                "\n Tocineta C/U:\t\t\t\t" + resultado11 + "Bs = " + tocineta + "$"+
				                "\n Golpe C/U:\t\t\t\t" + resultado12 + "Bs = " + golpe + "$"+
				                "\n Kraker y Hony C/U:\t\t\t" + resultado13 + "Bs = " + krakeryHony + "$"+
				                "\n Galleta Maria C/U:\t\t\t" + resultado14 + "Bs = " + gMaria + "$"+
				                "\n Club Social C/U:\t\t\t\t" + resultado15 + "Bs = " + clubSocial + "$"+
				                "\n Chupetas C/U:\t\t\t\t" + resultado16 + "Bs = " + chupeta + "$"+
				                "\n Chocolates C/U:\t\t\t\t" + resultado17 + "Bs = " + chocolates + "$"+
				                "\n Cheetos C/U:\t\t\t\t" + resultado18 + "Bs = " + cheetos + "$"+
				                "\n Pepito Pequeño C/U:\t\t\t" + resultado19 + "Bs = " + pepitopeque + "$"+
				                "\n Cheese Tris Pequeño C/U:\t\t\t" + resultado20 + "Bs = " + cheeseTrispeque + "$"+
				                "\n Dorito Grande C/U:\t\t\t" + resultado21 + "Bs = " + doritosGrandes + "$"+
				                "\n Dorito Pequeño C/U:\t\t\t" + resultado22 + "Bs = " + doritoPequeno + "$"+
				                "\n Ruffles C/U:\t\t\t\t" + resultado23 + "Bs = " + ruffles + "$"+
				                "\n Tandy C/U:\t\t\t\t" + resultado24 + "Bs = " + tandy + "$"+
				                "\n Caramelos C/U:\t\t\t\t" + resultado25 + "Bs = " + caramelos + "$"+
				                "\n Avelina C/U:\t\t\t\t" + resultado26 + "Bs = " + avelina + "$"+
				                "\n Galleta Maria Paquete C/U:\t\t\t" + resultado27 + "Bs = " + galletaMariaPaquete + "$"+
				                "\n Galleta Maria Unidad C/U:\t\t\t" + resultado28 + "Bs = " + galletaMariaUnidad + "$"+
				                "\n Platanito Natuchip C/U:\t\t\t" + resultado29 + "Bs = " + platanitosNatuchip + "$"+
				                "\n Takita C/U:\t\t\t\t" + resultado30 + "Bs = " + takita + "$"+
				                "\n Ruffles Grandes C/U:\t\t\t" + resultado31 + "Bs = " + rufflesGrandes + "$"+
				                "\n Natuchip 150Gr C/U:\t\t\t" + resultado32 + "Bs = " + natuchip150Gr + "$"+
				                "\n Platanito Pequeño C/U:\t\t\t" + resultado33 + "Bs = " + platanitoPeque + "$"+
				                "\n Rosquis Grandes C/U:\t\t\t" + resultado34 + "Bs = " + rosquisGrandes + "$"+
				                "\n Rosquis Pequeños C/U:\t\t\t" + resultado35 + "Bs = " + rosquisPeque + "$"+
				                "\n Compota C/U:\t\t\t\t" + resultado36 + "Bs = " + compota + "$"+
				                "\n Flaquito C/U:\t\t\t\t" + resultado37 + "Bs = " + flaquito + "$"+
				                "\n----------------------------------------------");
				
				resultado = precioDolar * rufflesPequeno;
				resultado2 = precioDolar * galletaDeSoda;
				resultado3 = precioDolar * taky;
				resultado4 = precioDolar * tosticos;
				resultado5 = precioDolar * natuchipAjoyPerejil;
				resultado6 = precioDolar * chocolateDucream;
				resultado7 = precioDolar * chocolatinoQuattro;
				resultado8 = precioDolar * galletasStar;
				resultado9 = precioDolar * starWafer;
				resultado10 = precioDolar * sandwichElegante;
				resultado11 = precioDolar * galletasDeMantequilla;
				resultado12 = precioDolar * galletasMerechal;
				
				MessageBox.Show("Chucherias:\n\n Ruffles Pequeños C/U:\t\t\t" + resultado + "Bs = " + rufflesPequeno + "$"+
				                "\n Galleta de Soda C/U:\t\t\t" + resultado2 + "Bs = " + galletaDeSoda + "$"+
				                "\n Taky C/U:\t\t\t\t" + resultado3 + "Bs = " + taky + "$"+
				                "\n Tosticos C/U:\t\t\t\t" + resultado4 + "Bs = " + tosticos + "$"+
				                "\n Natuchip Ajo y Perejil C/U:\t\t\t" + resultado5 + "Bs = " + natuchipAjoyPerejil + "$"+
				                "\n Chocolate Ducream C/U:\t\t\t" + resultado6 + "Bs = " + chocolateDucream + "$"+
				                "\n Chocolatino C/U:\t\t\t\t" + resultado7 + "Bs = " + chocolatinoQuattro + "$"+
				                "\n Galletas Star C/U:\t\t\t\t" + resultado8 + "Bs = " + galletasStar + "$"+
				                "\n Star Wafer C/U:\t\t\t\t" + resultado9 + "Bs = " + starWafer + "$"+
				                "\n Sandwich Elegante C/U:\t\t\t" + resultado10 + "Bs = " + sandwichElegante + "$"+
				                "\n Galletas de Mantequilla C/U:\t\t" + resultado11 + "Bs = " + galletasDeMantequilla + "$"+
				                "\n Galletas Merechal C/U:\t\t\t" + resultado12 + "Bs = " + galletasMerechal + "$"+
				                "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtOtrosClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * bombillo;
				resultado2 = precioDolar * velas;
				resultado3 = precioDolar * yesquero;
				resultado4 = precioDolar * pegaLoca;
				resultado5 = precioDolar * lena;
				resultado6 = precioDolar * chupichupi;
				resultado7 = precioDolar * papitasDePerro;
				
				MessageBox.Show("Otros Productos:\n\nBombillos C/U:\t\t" + resultado + "Bs = " + bombillo + "$"+
				                "\nVelas C/U:\t\t" + resultado2 + "Bs = " + velas + "$"+
				                "\nYesqueros C/U:\t\t" + resultado3 + "Bs = " + yesquero + "$"+
				                "\nPega Loca C/U:\t\t" + resultado4 + "Bs = " + pegaLoca + "$"+
				                "\nLeña C/U:\t\t" + resultado5 + "Bs = " + lena + "$"+
				                "\nChupiChupi C/U:\t\t" + resultado6 + "Bs = " + chupichupi + "$"+
				                "\nPapitas de Perro C/U:\t" + resultado7 + "Bs = " + papitasDePerro + "$"+
				                "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtLicoresClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * ron;
				resultado2 = precioDolar * superior;
				
				MessageBox.Show("Licores:\n\nRon C/U:\t\t" + resultado + "Bs = " + ron + "$"+
				                "\nSuperior C/U:\t" + resultado2 + "Bs = " + superior + "$"+
				                "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
		void BtPanesClick(object sender, EventArgs e)
		{
			try
			{
			   string par = textDolar.Text;
			   double precioDolar = double.Parse(textDolar.Text);
			   
				resultado = precioDolar * panSandwichBlanco750gr;
				resultado2 = precioDolar * panSandwichBlanco500gr;
				resultado3 = precioDolar * panSandwichIntegral750gr;
				resultado4 = precioDolar * panSandwichIntegral500gr;
				resultado5 = precioDolar * panIntegralPanyPasas650gr;
				resultado6 = precioDolar * hamburguesa8unidades350Grs;
				resultado7 = precioDolar * hamburguesa4unidades350Grs;
				resultado8 = precioDolar * panPerroCaliente10unidades350gr;
				resultado9 = precioDolar * panDulceDany500gr;
				resultado10 = precioDolar * panAndinoDonWin500gr;
				resultado11 = precioDolar * panArabe5Unidades350gr;
				resultado12 = precioDolar * panArabelIntegral5Unidades350gr;
				resultado13 = precioDolar * acemitas12Unidades600gr;
				resultado14 = precioDolar * cachitos12unidades600gr;
				resultado15 = precioDolar * panCampesino500gr;
				
				MessageBox.Show("Panes:\n\nPan de Sandwich Blanco 750Gr C/U:\t\t" + resultado + "Bs = " + panSandwichBlanco750gr + "$"+
				                "\nPan de Sandwich Blanco 500Gr C/U:\t\t" + resultado2 + "Bs = " + panSandwichBlanco500gr + "$"+
				                "\nPan de Sandwich Integral 750Gr C/U:\t\t" + resultado3 + "Bs = " + panSandwichIntegral750gr + "$"+
				                "\nPan de Sandwich Integral 500Gr C/U:\t\t" + resultado4 + "Bs = " + panSandwichIntegral500gr + "$"+
				                "\nPan integral Pan y Pasas 650Gr C/U:\t\t" + resultado5 + "Bs = " + panIntegralPanyPasas650gr + "$"+
				                "\nHamburguesa Gigante 4 Unidades 350Gr C/U:\t" + resultado6 + "Bs = " + hamburguesa4unidades350Grs + "$"+
				                "\nHamburguesa Pequeña 8 Unidades 350Gr C/U: " + resultado7 + "Bs = " + hamburguesa8unidades350Grs + "$"+
				                "\nPan Perro Caliente 10 Unidades 350Gr C/U:\t" + resultado8 + "Bs = " + panPerroCaliente10unidades350gr + "$"+
				                "\nPan Dulce Dany 500Gr C/U:\t\t\t" + resultado9 + "Bs = " + panDulceDany500gr + "$"+
				                "\nPan Andino Don Win 500Gr C/U:\t\t" + resultado10 + "Bs = " + panAndinoDonWin500gr + "$"+
				                "\nPan Arabe 5 Unidades 350Gr C/U:\t\t" + resultado11 + "Bs = " + panArabe5Unidades350gr + "$"+
				                "\nPan Arabe Integral 5 Unidades 350Gr C/U:\t" + resultado12 + "Bs = " + panArabelIntegral5Unidades350gr + "$"+
				                "\nAcemitas 12 Unidades 600Gr C/U:\t\t" + resultado13 + "Bs = " + acemitas12Unidades600gr + "$"+
				                "\nCachitos 12 Unidades 600Gr C/U:\t\t" + resultado14 + "Bs = " + cachitos12unidades600gr + "$"+
				                "\nPan Campesino 500Gr C/U:\t\t\t" + resultado15 + "Bs = " + panCampesino500gr + "$"+
				                "\n----------------------------------------------");
			}
			catch(Exception)
			{
				MessageBox.Show("Por favor introduce un monto en Dolar.");
			}
		}
	}
}
