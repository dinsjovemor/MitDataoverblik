# Scrum møder med AI sparring

Her registreres korte mødenoter fra den tilpassede arbejdsproces som enkeltperson. Noterne dokumenterer brugerens refleksion og AI-sparring. Planlagte møder markeres ikke som gennemførte.

Den hidtidige løbende dialog er opsummeret i Samarbejdslog.md. Gennemførte møder registreres nedenfor; de tomme afsnit er skabeloner.

## Sprintplanlægning

- Dato og tidspunkt:
- Sprintmål:
- Valgte backlogpunkter:
- Opgaver og prioritering:
- Usikkerheder:
- Beslutninger og næste skridt:

## Kort status

- Dato og tidspunkt:
- Hvad er nået:
- Næste opgave:
- Forhindringer og behov for hjælp:

## Sprint review

- Dato og tidspunkt:
- Hvad blev demonstreret og afprøvet:
- Hvilke acceptkriterier er opfyldt:
- Feedback og beslutninger:
- Hvad mangler eller går tilbage til backlog:

## Retrospective

- Dato og tidspunkt:
- Hvad fungerede i arbejdsprocessen:
- Hvad var vanskeligt:
- Hvilken konkret forbedring prøves næste gang:


## Gennemført møde 17. oktober 2026

Referat af samtalen om sprint 1 review, retrospective, Definition of Done og planlægning af sprint 2. Noteret kl. 21.38 dansk tid; dette er registreringstidspunktet, ikke et præcist start- eller sluttidspunkt for mødet. AI har hjulpet med facilitering og opsummering; den studerende har taget stilling til beslutningerne.

### Sprint 1 review

- Grundlag: Tidligere manuelle afprøvninger, skærmbilleder og dialog om PB01–PB03 samt det aktuelle skærmbillede af forsiden. Der blev ikke gennemført en ny fuld demonstration eller ny teknisk kontrol under mødet.
- Den studerende fremhævede afprøvning af både fungerende forløb og ugyldige indtastninger som særligt værdifuldt.
- Den studerende vurderede brugerfladen som ligetil. Dette er egen vurdering, ikke en brugertest med andre.
- PB01–PB03 er tidligere merged og markeret Done. Opfølgning på genfinding af gemte anmodninger på tværs af sider og link til Mine anmodninger er fortsat udestående og indgår i PB04. Markeringen Done er derfor ikke dokumentation for, at denne opfølgning er udført.
- Nyt undersøgelsespunkt: Blazors fejlpanel vises nederst på forsiden. Årsagen er ukendt. Den studerende registrerede Question 1 på boardet og i historikken.
- Beslutning: Undersøg fejlpanelet før videre kodearbejde på PB04.

### Retrospective

- Det fungerede: AI-støtten aflaster overblik og mikroplanlægning, så den studerende kan koncentrere sig om at lære kode og Scrum.
- Det krævede energi: At forklare projektet, egne ønsker og arbejdsform i opstarten samt løbende holde øje med, om alle forhold bliver husket.
- Aftalt forbedring 1: Korte forståelsesstop efter delmål. Den studerende forklarer formålet og sammenhængen med egne ord.
- Aftalt forbedring 2: Fælles afslutningstjekliste med acceptkriterier, afprøvning, resterende arbejde, board og dokumentation. AI hjælper med at gennemgå den.
- AI-feedback: Afhængigheder og resterende acceptkriterier skal synliggøres, før en opgave kaldes færdig. PB03/PB04 blev brugt som konkret eksempel.
- Visuel tilpasning: Planlagt og faktisk fremdrift vises i to linjer med samme indrykning og PB-punkter direkte over hinanden. Den oprindelige plan bevares som sammenligningsgrundlag.

### Vedtaget Definition of Done

Gælder fremadrettet. Den gør ikke tidligere opgaver automatisk godkendte efter de nye kriterier.

1. Acceptkriterierne er gennemgået, afprøvet og opfyldt. Mangler dokumenteres; et ikke-opfyldt acceptkriterium betyder, at opgaven endnu ikke er Done.
2. Koden kan bygges, og relevante automatiske tests samt obligatoriske PR-kontroller består.
3. Den studerende kan med egne ord forklare ændringens formål og de væsentlige sammenhænge, gerne med støtte fra kode og tegninger.
4. Ændringen er gennemgået og merged til main via en PR med tilknyttet opgave. Board og relevant dokumentation er ajour. Gennemgangen beskrives som egen gennemgang med AI-støtte.

### Sprint 2 planlægning

- Aftalt periode: 17.–21. oktober 2026. Review og retrospective planlægges til onsdag 21. oktober og er endnu ikke gennemført.
- Sprintmål: Borgeren kan følge sine rettelsesanmodninger, og en administrator kan ændre deres status med adgang styret af brugerroller.
- Rækkefølge: Undersøg fejlpanelet, PB04 Mine anmodninger inklusive opfølgning fra PB03, PB05 Login, PB06 Administration og samlet afprøvning.
- PB04 er Issue #6 på branchen feature/6-mine-anmodninger. Kodearbejdet afventede mødet.
- Den oprindelige ugeplan bevares som sammenligningsgrundlag. Torsdag 22. oktober er fortsat buffer og forberedelse.
- Næste konkrete skridt: Efter pausen undersøges det synlige fejlpanel uden at antage, at årsagen allerede er kendt.

## Gennemført møde 21. oktober 2026

Sprint 2 review og retrospective gennemført i chatten. Referatet er registreret 21. oktober kl. 23.12 dansk tid. Dette er registreringstidspunktet, ikke et præcist start- eller sluttidspunkt for mødet. AI faciliterede og sammenfattede; den studerende tog stilling til beslutningerne. Historiske planer ovenfor bevares som historik; dagens referat angiver, at sprintafslutningen nu er gennemført.

### Sprint 2 review

- Sprintperiode: 17.–21. oktober 2026.
- Sprintmål: Borgeren kan følge sine rettelsesanmodninger, og en administrator kan ændre deres status med adgang styret af brugerroller.
- Gennemført arbejde ifølge udviklingsdialogen: PB04 Mine anmodninger, PB05 Simuleret login, PB06 Administration og det senere tilføjede PB07 Visuel forbedring. Opgaverne er merged, markeret Done og synkroniseret til Azure DevOps og GitHub ifølge de tidligere delte resultater.
- Reviewgrundlag: Den samlede manuelle afprøvning den 20. oktober, skærmbilleder og brugerens bekræftelser samt læsning af den aktuelle kode den 21. oktober. Der blev ikke udført en ny fuld browserdemonstration eller genkørsel af tests under dagens møde.
- Den studerende fremhævede, at forløbet virkede via navigation i samme browserfane uden fuld genindlæsning. Borgeren oprettede en anmodning, administratoren ændrede status, og borgeren kunne se ændringen.
- Den studerende forklarede afgrænsningen: Demologin gælder den interaktive forbindelse og udsteder ikke en logincookie. Registreret cookie-authentication understøtter blandt andet videresendelse ved direkte adgang, men udsteder ikke en cookie gennem demologinets nuværende forløb. Anmodninger i den scoped service kan gå tabt ved ny forbindelse.
- På den studerendes initiativ blev kravene sammenholdt med løsningen. De seks tekniske minimumsområder har konkrete eksempler: komponenter, services/DI, formular/model/binding/validering, datahåndtering med søgning/filtre, shared state og authentication/rollebaseret authorization.
- Vurdering: Sprintmålet er nået inden for den dokumenterede prototypeafgrænsning. Dette er projektets egen vurdering og ikke underviserens endelige bedømmelse eller en uafhængig sikkerhedsaudit.
- Beslutning godkendt af den studerende: Fasthold løsningen uden nye funktioner. Brug resterende tid på procesdokumentation, kodeforståelse, præsentationsøvelse og afleveringskontrol.
- Resterende arbejde: Gennemgang af kommentarer og dokumentation i Git, tidsmålt præsentation på højst 15 minutter og klargøring/kontrol af kildekodepakken før fredag 23. oktober kl. 12.
- Detaljerede testresultater og ikke-afprøvede forhold findes i Dokumentation/Slutkontrol-2026-10-20.md.

### Sprint 2 retrospective

- Forståelsesstop: Korte spørgsmål, visuelle forklaringer og gentagen kodegennemgang styrkede den studerendes forståelse og selvtillid. Muligheden for at vende tilbage til stoffet og selv forklare eller afprøve det havde værdi.
- Afslutningstjekliste: Visuel afkrydsning gjorde fremdriften konkret og gav oplevelsen af at lykkes med ét punkt ad gangen.
- Kombinationen af Scrum-struktur og AI-sparring gjorde det lettere at dele projektet op i små opgaver. Forspringet gav plads til designløft, gentagelse og præsentationsforberedelse.
- De to forbedringer fra sidste retrospective fortsættes: forståelsesstop og fælles afslutningstjekliste.
- Ny forbedring foreslået af den studerende og aftalt: Under kodegennemgangen kontrollerer AI den studerendes kommentarer for teknisk korrekthed og tydelighed. Kommentarerne skal fungere som fremtidige hjælpelinjer til, hvad der sker hvor.
- Praktisk arbejdsform: Gennemgå én lille kodebid og dens kommentarer ad gangen. Skeln mellem kodens faktiske handling og betydningen i appens forløb. Brug korte kommentarer med den studerendes egne ord og uden punktum til sidst.
- Næste skridt: Fortsæt den afgrænsede kodegennemgang med kommentarkontrol og forbindelser til præsentationen.
