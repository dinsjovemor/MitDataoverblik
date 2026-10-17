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
