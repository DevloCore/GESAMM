USE [GESAMM]
GO
/****** Object:  Table [dbo].[DECISION]    Script Date: 18/12/2023 17:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DECISION](
	[DEC_ID] [int] NOT NULL,
	[libelleDecision] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DEC_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ETAPE]    Script Date: 18/12/2023 17:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ETAPE](
	[ETA_NUM] [int] NOT NULL,
	[ETA_LIBELLE] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ETA_NUM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ETAPENORME]    Script Date: 18/12/2023 17:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ETAPENORME](
	[ETA_NUM] [int] NOT NULL,
	[NORME] [varchar](30) NULL,
	[DATENORME] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ETA_NUM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FAMILLE]    Script Date: 18/12/2023 17:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FAMILLE](
	[FAM_CODE] [nvarchar](50) NOT NULL,
	[FAM_LIBELLE] [nvarchar](100) NOT NULL,
	[FAM_NB_MEDI_AMM] [int] NOT NULL,
 CONSTRAINT [PK_FAMILLE] PRIMARY KEY CLUSTERED 
(
	[FAM_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HISTORIQUE]    Script Date: 18/12/2023 17:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HISTORIQUE](
	[HIS_ID] [int] NOT NULL,
	[HIS_DATEMAJ] [date] NOT NULL,
	[HIS_NORMEAVANT] [varchar](255) NOT NULL,
	[HIS_NORMEAPRES] [varchar](255) NOT NULL,
	[HIS_DATENORMEAVANT] [date] NOT NULL,
	[HIS_DATENORMEAPRES] [date] NOT NULL,
	[HIS_ETA_NUM] [int] NULL,
	[HIS_USER] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HIS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICAMENT]    Script Date: 18/12/2023 17:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICAMENT](
	[MED_DEPOTLEGAL] [nvarchar](50) NOT NULL,
	[MED_NOMCOMMERCIAL] [nvarchar](50) NOT NULL,
	[FAM_CODE] [nvarchar](50) NOT NULL,
	[MED_COMPOSITION] [nvarchar](100) NOT NULL,
	[MED_EFFETS] [nvarchar](200) NOT NULL,
	[MED_CONTREINDIC] [nvarchar](250) NOT NULL,
	[MED_PRIXECHANTILLON] [real] NULL,
	[MED_AMM] [varchar](10) NULL,
	[MED_D_ETAPE] [int] NOT NULL,
 CONSTRAINT [PK_MEDICAMENT] PRIMARY KEY CLUSTERED 
(
	[MED_DEPOTLEGAL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UTILISATEUR]    Script Date: 18/12/2023 17:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UTILISATEUR](
	[ID] [int] NOT NULL,
	[NOM] [varchar](40) NOT NULL,
	[password] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WORKFLOW]    Script Date: 18/12/2023 17:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WORKFLOW](
	[WOR_ETA_NUM] [int] NOT NULL,
	[WOR_DEC_ID] [int] NOT NULL,
	[WOR_MED_DEPOTLEGAL] [nvarchar](50) NOT NULL,
	[WOR_DATE_DECISION] [date] NOT NULL,
 CONSTRAINT [WOR_PK1] PRIMARY KEY CLUSTERED 
(
	[WOR_ETA_NUM] ASC,
	[WOR_MED_DEPOTLEGAL] ASC,
	[WOR_DEC_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DECISION] ([DEC_ID], [libelleDecision]) VALUES (1, N'oui')
INSERT [dbo].[DECISION] ([DEC_ID], [libelleDecision]) VALUES (2, N'non')
GO
INSERT [dbo].[ETAPE] ([ETA_NUM], [ETA_LIBELLE]) VALUES (1, N'Définition du protocole de validation')
INSERT [dbo].[ETAPE] ([ETA_NUM], [ETA_LIBELLE]) VALUES (2, N'Pharmacologie expérimentale')
INSERT [dbo].[ETAPE] ([ETA_NUM], [ETA_LIBELLE]) VALUES (3, N'Toxicologie')
INSERT [dbo].[ETAPE] ([ETA_NUM], [ETA_LIBELLE]) VALUES (4, N'Pharmacocinétique')
INSERT [dbo].[ETAPE] ([ETA_NUM], [ETA_LIBELLE]) VALUES (5, N'Expérimentation animale')
INSERT [dbo].[ETAPE] ([ETA_NUM], [ETA_LIBELLE]) VALUES (6, N'Méthodes alternatives')
INSERT [dbo].[ETAPE] ([ETA_NUM], [ETA_LIBELLE]) VALUES (7, N'Essais cliniques')
INSERT [dbo].[ETAPE] ([ETA_NUM], [ETA_LIBELLE]) VALUES (8, N'Autorisation Mise sur le Marché')
GO
INSERT [dbo].[ETAPENORME] ([ETA_NUM], [NORME], [DATENORME]) VALUES (1, NULL, NULL)
INSERT [dbo].[ETAPENORME] ([ETA_NUM], [NORME], [DATENORME]) VALUES (2, N'XKVOKAS', CAST(N'2021-12-10' AS Date))
INSERT [dbo].[ETAPENORME] ([ETA_NUM], [NORME], [DATENORME]) VALUES (3, NULL, NULL)
INSERT [dbo].[ETAPENORME] ([ETA_NUM], [NORME], [DATENORME]) VALUES (4, NULL, NULL)
INSERT [dbo].[ETAPENORME] ([ETA_NUM], [NORME], [DATENORME]) VALUES (5, N'JIVIOQSA', CAST(N'2019-06-15' AS Date))
INSERT [dbo].[ETAPENORME] ([ETA_NUM], [NORME], [DATENORME]) VALUES (6, NULL, NULL)
INSERT [dbo].[ETAPENORME] ([ETA_NUM], [NORME], [DATENORME]) VALUES (7, NULL, NULL)
INSERT [dbo].[ETAPENORME] ([ETA_NUM], [NORME], [DATENORME]) VALUES (8, NULL, NULL)
GO
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AA', N'Antalgiques en association', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AAA', N'Antalgiques antipyr�tiques en association', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AAC', N'Antid�presseur d''action centrale', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AAH', N'Antivertigineux antihistaminique H1', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'ABA', N'Antibiotique antituberculeux', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'ABC', N'Antibiotique antiacn�ique local', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'ABP', N'Antibiotique de la famille des b�ta-lactamines (p�nicilline A)', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AFC', N'Antibiotique de la famille des cyclines', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AFM', N'Antibiotique de la famille des macrolides', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AH', N'Antihistaminique H1 local', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AIM', N'Antid�presseur imipraminique (tricyclique)', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AIN', N'Antid�presseur inhibiteur s�lectif de la recapture de la s�rotonine', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'ALO', N'Antibiotique local (ORL)', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'ANS', N'Antid�presseur IMAO non s�lectif', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AO', N'Antibiotique ophtalmique', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AP', N'Antipsychotique normothymique', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AUM', N'Antibiotique urinaire minute', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'CRT', N'Cortico�de, antibiotique et antifongique � usage local', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'HYP', N'Hypnotique antihistaminique', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'PSA', N'Psychostimulant, antiasth�nique', 0)
GO
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'3MYC7', N'TRIMYCINE', N'CRT', N'Triamcinolone (ac�tonide) + N�omycine + Nystatine', N'Ce m�dicament est un cortico�de � activit� forte ou tr�s forte associ� � un antibiotique et un antifongique, utilis� en application locale dans certaines atteintes cutan�es surinfect�es.', N'Ce m�dicament est contre-indiqu� en cas d''allergie � l''un des constituants, d''infections de la peau ou de parasitisme non trait�s, d''acn�. Ne pas appliquer sur une plaie, ni sous un pansement occlusif.', NULL, NULL, 8)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'ADIMOL9', N'ADIMOL', N'ABP', N'Amoxicilline + Acide clavulanique', N'Ce m�dicament, plus puissant que les p�nicillines simples, est utilis� pour traiter des infections bact�riennes sp�cifiques.', N'Ce m�dicament est contre-indiqu� en cas d''allergie aux p�nicillines ou aux c�phalosporines.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'AMOPIL7', N'AMOPIL', N'ABP', N'Amoxicilline', N'Ce m�dicament, plus puissant que les p�nicillines simples, est utilis� pour traiter des infections bact�riennes sp�cifiques.', N'Ce m�dicament est contre-indiqu� en cas d''allergie aux p�nicillines. Il doit �tre administr� avec prudence en cas d''allergie aux c�phalosporines.', NULL, NULL, 5)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'AMOX45', N'AMOXAR', N'ABP', N'Amoxicilline', N'Ce m�dicament, plus puissant que les p�nicillines simples, est utilis� pour traiter des infections bact�riennes sp�cifiques.', N'La prise de ce m�dicament peut rendre positifs les tests de d�pistage du dopage.', 12.2, NULL, 1)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'AMOXIG12', N'AMOXI G�', N'ABP', N'Amoxicilline', N'Ce m�dicament, plus puissant que les p�nicillines simples, est utilis� pour traiter des infections bact�riennes sp�cifiques.', N'Ce m�dicament est contre-indiqu� en cas d''allergie aux p�nicillines. Il doit �tre administr� avec prudence en cas d''allergie aux c�phalosporines.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'APATOUX22', N'APATOUX Vitamine C', N'ALO', N'Tyrothricine + T�traca�ne + Acide ascorbique (Vitamine C)', N'Ce m�dicament est utilis� pour traiter les affections de la bouche et de la gorge.', N'Ce m�dicament est contre-indiqu� en cas d''allergie � l''un des constituants, en cas de ph�nylc�tonurie et chez l''enfant de moins de 6 ans.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'BACTIG10', N'BACTIGEL', N'ABC', N'Erythromycine', N'Ce m�dicament est utilis� en application locale pour traiter l''acn� et les infections cutan�es bact�riennes associ�es.', N'Ce m�dicament est contre-indiqu� en cas d''allergie aux antibiotiques de la famille des macrolides ou des lincosanides.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'BACTIV13', N'BACTIVIL', N'AFM', N'Erythromycine', N'Ce m�dicament est utilis� pour traiter des infections bact�riennes sp�cifiques.', N'Ce m�dicament est contre-indiqu� en cas d''allergie aux macrolides (dont le chef de file est l''�rythromycine).', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'BITALV', N'BIVALIC', N'AAA', N'Dextropropoxyph�ne + Parac�tamol', N'Ce m�dicament est utilis� pour traiter les douleurs d''intensit� mod�r�e ou intense.', N'Ce m�dicament est contre-indiqu� en cas d''allergie aux m�dicaments de cette famille, d''insuffisance h�patique ou d''insuffisance r�nale.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'CARTION6', N'CARTION', N'AAA', N'Acide ac�tylsalicylique (aspirine) + Acide ascorbique (Vitamine C) + Parac�tamol', N'Ce m�dicament est utilis� dans le traitement symptomatique de la douleur ou de la fi�vre.', N'Ce m�dicament est contre-indiqu� en cas de troubles de la coagulation (tendances aux h�morragies), d''ulc�re gastroduod�nal, maladies graves du foie.', 2.45, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'CLAZER6', N'CLAZER', N'AFM', N'Clarithromycine', N'Ce m�dicament est utilis� pour traiter des infections bact�riennes sp�cifiques. Il est �galement utilis� dans le traitement de l''ulc�re gastro-duod�nal, en association avec d''autres m�dicaments.', N'Ce m�dicament est contre-indiqu� en cas d''allergie aux macrolides (dont le chef de file est l''�rythromycine).', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'ddd', N'ddd', N'AAC', N'ddd', N'ddd', N'ddd', 0, N'ddd', 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'DEPOT', N'NOMCOM', N'AA', N'COMPO', N'EFFETS', N'CONTREINDIC', 667, N'Yup', 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'DEPRIL9', N'DEPRAMIL', N'AIM', N'Clomipramine', N'Ce m�dicament est utilis� pour traiter les �pisodes d�pressifs s�v�res, certaines douleurs rebelles, les troubles obsessionnels compulsifs et certaines �nur�sies chez l''enfant.', N'Ce m�dicament est contre-indiqu� en cas de glaucome ou d''ad�nome de la prostate, d''infarctus r�cent, ou si vous avez re�u un traitement par IMAO durant les 2 semaines pr�c�dentes ou en cas d''allergie aux antid�presseurs imipraminiques.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'DIMIRTAM6', N'DIMIRTAM', N'AAC', N'Mirtazapine', N'Ce m�dicament est utilis� pour traiter les �pisodes d�pressifs s�v�res.', N'La prise de ce produit est contre-indiqu�e en cas de d''allergie � l''un des constituants.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'DOLRIL7', N'DOLORIL', N'AAA', N'Acide ac�tylsalicylique (aspirine) + Acide ascorbique (Vitamine C) + Parac�tamol', N'Ce m�dicament est utilis� dans le traitement symptomatique de la douleur ou de la fi�vre.', N'Ce m�dicament est contre-indiqu� en cas d''allergie au parac�tamol ou aux salicylates.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'DORNOM8', N'NORMADOR', N'HYP', N'Doxylamine', N'Ce m�dicament est utilis� pour traiter l''insomnie chez l''adulte.', N'Ce m�dicament est contre-indiqu� en cas de glaucome, de certains troubles urinaires (r�tention urinaire) et chez l''enfant de moins de 15 ans.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'EQUILARX6', N'EQUILAR', N'AAH', N'M�clozine', N'Ce m�dicament est utilis� pour traiter les vertiges et pour pr�venir le mal des transports.', N'Ce m�dicament ne doit pas �tre utilis� en cas d''allergie au produit, en cas de glaucome ou de r�tention urinaire.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'EVILR7', N'EVEILLOR', N'PSA', N'Adrafinil', N'Ce m�dicament est utilis� pour traiter les troubles de la vigilance et certains symptomes neurologiques chez le sujet ag�.', N'Ce m�dicament est contre-indiqu� en cas d''allergie � l''un des constituants.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'INSXT5', N'INSECTIL', N'AH', N'Diph�nydramine', N'Ce m�dicament est utilis� en application locale sur les piq�res d''insecte et l''urticaire.', N'Ce m�dicament est contre-indiqu� en cas d''allergie aux antihistaminiques.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'JOVAI8', N'JOVENIL', N'AFM', N'Josamycine', N'Ce m�dicament est utilis� pour traiter des infections bact�riennes sp�cifiques.', N'Ce m�dicament est contre-indiqu� en cas d''allergie aux macrolides (dont le chef de file est l''�rythromycine).', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'LIDOXY23', N'LIDOXYTRACINE', N'AFC', N'Oxyt�tracycline +Lidoca�ne', N'Ce m�dicament est utilis� en injection intramusculaire pour traiter certaines infections sp�cifiques.', N'Ce m�dicament est contre-indiqu� en cas d''allergie � l''un des constituants. Il ne doit pas �tre associ� aux r�tino�des.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'LITHOR12', N'LITHORINE', N'AP', N'Lithium', N'Ce m�dicament est indiqu� dans la pr�vention des psychoses maniaco-d�pressives ou pour traiter les �tats maniaques.', N'Ce m�dicament ne doit pas �tre utilis� si vous �tes allergique au lithium. Avant de prendre ce traitement, signalez � votre m�decin traitant si vous souffrez d''insuffisance r�nale, ou si vous avez un r�gime sans sel.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'PARMOL16', N'PARMOCODEINE', N'AA', N'Cod�ine + Parac�tamol', N'Ce m�dicament est utilis� pour le traitement des douleurs lorsque des antalgiques simples ne sont pas assez efficaces.', N'Ce m�dicament est contre-indiqu� en cas d''allergie � l''un des constituants, chez l''enfant de moins de 15 Kg, en cas d''insuffisance h�patique ou respiratoire, d''asthme, de ph�nylc�tonurie et chez la femme qui allaite.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'PHYSOI8', N'PHYSICOR', N'PSA', N'Sulbutiamine', N'Ce m�dicament est utilis� pour traiter les baisses d''activit� physique ou psychique, souvent dans un contexte de d�pression.', N'Ce m�dicament est contre-indiqu� en cas d''allergie � l''un des constituants.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'PIRIZ8', N'PIRIZAN', N'ABA', N'Pyrazinamide', N'Ce m�dicament est utilis�, en association � d''autres antibiotiques, pour traiter la tuberculose.', N'Ce m�dicament est contre-indiqu� en cas d''allergie � l''un des constituants, d''insuffisance r�nale ou h�patique, d''hyperuric�mie ou de porphyrie.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'POMDI20', N'POMADINE', N'AO', N'Bacitracine', N'Ce m�dicament est utilis� pour traiter les infections oculaires de la surface de l''oeil.', N'Ce m�dicament est contre-indiqu� en cas d''allergie aux antibiotiques appliqu�s localement.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'TROXT21', N'TROXADET', N'AIN', N'Parox�tine', N'Ce m�dicament est utilis� pour traiter la d�pression et les troubles obsessionnels compulsifs. Il peut �galement �tre utilis� en pr�vention des crises de panique avec ou sans agoraphobie.', N'Ce m�dicament est contre-indiqu� en cas d''allergie au produit.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'TXISOL22', N'TOUXISOL Vitamine C', N'ALO', N'Tyrothricine + Acide ascorbique (Vitamine C)', N'Ce m�dicament est utilis� pour traiter les affections de la bouche et de la gorge.', N'Ce m�dicament est contre-indiqu� en cas d''allergie � l''un des constituants et chez l''enfant de moins de 6 ans.', NULL, NULL, 0)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON], [MED_AMM], [MED_D_ETAPE]) VALUES (N'URIEG6', N'URIREGUL', N'AUM', N'Fosfomycine trom�tamol', N'Ce m�dicament est utilis� pour traiter les infections urinaires simples chez la femme de moins de 65 ans.', N'La prise de ce m�dicament est contre-indiqu�e en cas d''allergie � l''un des constituants et d''insuffisance r�nale.', NULL, NULL, 0)
GO
INSERT [dbo].[UTILISATEUR] ([ID], [NOM], [password]) VALUES (1, N'user', N'user')
INSERT [dbo].[UTILISATEUR] ([ID], [NOM], [password]) VALUES (2, N'admin', N'leprof')
GO
INSERT [dbo].[WORKFLOW] ([WOR_ETA_NUM], [WOR_DEC_ID], [WOR_MED_DEPOTLEGAL], [WOR_DATE_DECISION]) VALUES (1, 1, N'AMOX45', CAST(N'2023-12-14' AS Date))
GO
ALTER TABLE [dbo].[FAMILLE] ADD  DEFAULT ((0)) FOR [FAM_NB_MEDI_AMM]
GO
ALTER TABLE [dbo].[MEDICAMENT] ADD  DEFAULT ((0)) FOR [MED_D_ETAPE]
GO
ALTER TABLE [dbo].[ETAPENORME]  WITH CHECK ADD  CONSTRAINT [FK1EN] FOREIGN KEY([ETA_NUM])
REFERENCES [dbo].[ETAPE] ([ETA_NUM])
GO
ALTER TABLE [dbo].[ETAPENORME] CHECK CONSTRAINT [FK1EN]
GO
ALTER TABLE [dbo].[HISTORIQUE]  WITH CHECK ADD  CONSTRAINT [FK1HISTO] FOREIGN KEY([HIS_ETA_NUM])
REFERENCES [dbo].[ETAPE] ([ETA_NUM])
GO
ALTER TABLE [dbo].[HISTORIQUE] CHECK CONSTRAINT [FK1HISTO]
GO
ALTER TABLE [dbo].[HISTORIQUE]  WITH CHECK ADD  CONSTRAINT [FKKK1] FOREIGN KEY([HIS_USER])
REFERENCES [dbo].[UTILISATEUR] ([ID])
GO
ALTER TABLE [dbo].[HISTORIQUE] CHECK CONSTRAINT [FKKK1]
GO
ALTER TABLE [dbo].[MEDICAMENT]  WITH CHECK ADD  CONSTRAINT [fk1] FOREIGN KEY([FAM_CODE])
REFERENCES [dbo].[FAMILLE] ([FAM_CODE])
GO
ALTER TABLE [dbo].[MEDICAMENT] CHECK CONSTRAINT [fk1]
GO
ALTER TABLE [dbo].[WORKFLOW]  WITH CHECK ADD  CONSTRAINT [WOR_FK1] FOREIGN KEY([WOR_ETA_NUM])
REFERENCES [dbo].[ETAPE] ([ETA_NUM])
GO
ALTER TABLE [dbo].[WORKFLOW] CHECK CONSTRAINT [WOR_FK1]
GO
ALTER TABLE [dbo].[WORKFLOW]  WITH CHECK ADD  CONSTRAINT [WOR_FK2] FOREIGN KEY([WOR_MED_DEPOTLEGAL])
REFERENCES [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL])
GO
ALTER TABLE [dbo].[WORKFLOW] CHECK CONSTRAINT [WOR_FK2]
GO
ALTER TABLE [dbo].[WORKFLOW]  WITH CHECK ADD  CONSTRAINT [WOR_FK3] FOREIGN KEY([WOR_DEC_ID])
REFERENCES [dbo].[DECISION] ([DEC_ID])
GO
ALTER TABLE [dbo].[WORKFLOW] CHECK CONSTRAINT [WOR_FK3]
GO
/****** Object:  StoredProcedure [dbo].[prc_ajout_medicament]    Script Date: 18/12/2023 17:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_ajout_medicament]
    -- Add the parameters for the stored procedure here
    @med_depotLegal Varchar(255),
    @med_nomCommercial Varchar(255),
    @fam_code varchar(3),
    @med_composition Varchar(255),
    @med_effets Varchar(255),
    @med_contreIndications Varchar(255),
    @med_prixEchantillon int,
    @med_amm Varchar(255)

 

AS
BEGIN
    SET NOCOUNT ON;
    
    -- Insertion du client
    INSERT INTO MEDICAMENT (MED_NOMCOMMERCIAL, FAM_CODE, MED_DEPOTLEGAL, MED_COMPOSITION, MED_EFFETS, MED_CONTREINDIC, MED_PRIXECHANTILLON, MED_AMM)
    Values (@med_nomCommercial, @fam_code, @med_depotLegal, @med_composition, @med_effets, @med_contreIndications, @med_prixEchantillon, @med_amm )
END
GO
/****** Object:  StoredProcedure [dbo].[prc_liste_familles]    Script Date: 18/12/2023 17:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[prc_liste_familles]
as
begin
select FAM_CODE as code, FAM_LIBELLE as libelle, FAM_NB_MEDI_AMM as nbMediAmm from FAMILLE
end
GO
/****** Object:  StoredProcedure [dbo].[prc_liste_medicaments]    Script Date: 18/12/2023 17:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[prc_liste_medicaments]
as
begin
select MED_DEPOTLEGAL as depotLegal, MED_NOMCOMMERCIAL as nomCommercial, MED_COMPOSITION as composition, MED_EFFETS as effets, MED_CONTREINDIC as contreIndications, MED_PRIXECHANTILLON as prixEchantillon, FAM_CODE as codeFamille, MED_AMM as amm, MED_D_ETAPE as derniereEtape
from MEDICAMENT
end
GO
/****** Object:  StoredProcedure [dbo].[prc_maj_norme]    Script Date: 18/12/2023 17:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_maj_norme](@idUser INT, @normeAV varchar(255) null, @normeAP varchar(255) null, @dateAV DATE null, @dateAP DATE null, @numEtape int)
AS
BEGIN

 

    Update ETAPENORME
    set NORME = @normeAP,
    DATENORME = @dateAP
	where ETA_NUM = @numEtape

	declare @id int
	select @id = max(HIS_ID) from HISTORIQUE
	set @id = @id + 1
	if @id is null
	begin
		set @id = 1
	end


    INSERT INTO HISTORIQUE
    (HIS_DATEMAJ, HIS_USER, HIS_NORMEAVANT, HIS_NORMEAPRES, HIS_DATENORMEAVANT, HIS_DATENORMEAPRES, HIS_ETA_NUM, HIS_ID)
    VALUES(GETDATE(), @idUser, @normeAV, @normeAP, @dateAV, @dateAP, @numEtape, @id)
END
GO
/****** Object:  Trigger [dbo].[trg_medicament_after_update]    Script Date: 18/12/2023 17:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trg_medicament_after_update]
on [dbo].[MEDICAMENT]
after update
as begin
set nocount on
	if (update (MED_AMM))
	begin
		declare @theCode as varchar(10)
		declare @count as int

		select @theCode = FAM_CODE from inserted

		select @count = count(*) from MEDICAMENT
		where FAM_CODE = @theCode and MED_AMM is not null

		update FAMILLE
		set FAM_NB_MEDI_AMM = @count
		where FAM_CODE = @theCode
	end

end
GO
ALTER TABLE [dbo].[MEDICAMENT] ENABLE TRIGGER [trg_medicament_after_update]
GO
/****** Object:  Trigger [dbo].[trg_insertion_workflow]    Script Date: 18/12/2023 17:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trg_insertion_workflow]
on [dbo].[WORKFLOW]
after insert
as begin

declare @med VARCHAR(255)
declare @etape int

select @med = WOR_MED_DEPOTLEGAL, @etape = WOR_ETA_NUM from inserted

update MEDICAMENT
set MED_D_ETAPE = @etape
where MED_DEPOTLEGAL = @med

end
GO
ALTER TABLE [dbo].[WORKFLOW] ENABLE TRIGGER [trg_insertion_workflow]
GO
