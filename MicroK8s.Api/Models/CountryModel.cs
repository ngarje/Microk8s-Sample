﻿using System;
using System.Collections.Generic;

namespace MicroK8s.Api.Models
{
    public class CountryModel
    {
        public CountryModel(long id, string name, string code)
        {
            this.Id = id;
            this.Name = name;
            this.Code = code;
        }

        public long Id { get; private set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public RegionModel Region { get; set; }
        public DateTime CachedTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public static List<CountryModel> Countries => new List<CountryModel> {
            new CountryModel(2,"United Arab Emirates","AE"),
new CountryModel(3,"Afghanistan","AF"),
new CountryModel(4,"Antigua And Barbuda","AG"),
new CountryModel(5,"Anguilla","AI"),
new CountryModel(6,"Albania","AL"),
new CountryModel(7,"Armenia","AM"),
new CountryModel(8,"Angola","AO"),
new CountryModel(9,"Antarctica","AQ"),
new CountryModel(10,"Argentina","AR"),
new CountryModel(11,"American Samoa","AS"),
new CountryModel(12,"Austria","AT"),
new CountryModel(13,"Australia","AU"),
new CountryModel(14,"Aruba","AW"),
new CountryModel(15,"Åland Islands","AX"),
new CountryModel(16,"Azerbaijan","AZ"),
new CountryModel(17,"Bosnia And Herzegovina","BA"),
new CountryModel(18,"Barbados","BB"),
new CountryModel(19,"Bangladesh","BD"),
new CountryModel(20,"Belgium","BE"),
new CountryModel(21,"Burkina Faso","BF"),
new CountryModel(22,"Bulgaria","BG"),
new CountryModel(23,"Bahrain","BH"),
new CountryModel(24,"Burundi","BI"),
new CountryModel(25,"Benin","BJ"),
new CountryModel(26,"Saint Barthélemy","BL"),
new CountryModel(27,"Bermuda","BM"),
new CountryModel(28,"Brunei Darussalam","BN"),
new CountryModel(29,"Bolivia, Plurinational State Of","BO"),
new CountryModel(30,"Bonaire, Sint Eustatius And Saba","BQ"),
new CountryModel(31,"Brazil","BR"),
new CountryModel(32,"Bahamas","BS"),
new CountryModel(33,"Bhutan","BT"),
new CountryModel(34,"Bouvet Island","BV"),
new CountryModel(35,"Botswana","BW"),
new CountryModel(36,"Belarus","BY"),
new CountryModel(37,"Belize","BZ"),
new CountryModel(38,"Canada","CA"),
new CountryModel(39,"Cocos (Keeling) Islands","CC"),
new CountryModel(40,"Congo, The Democratic Republic Of The","CD"),
new CountryModel(41,"Central African Republic","CF"),
new CountryModel(42,"Congo","CG"),
new CountryModel(43,"Switzerland","CH"),
new CountryModel(44,"Côte D'Ivoire","CI"),
new CountryModel(45,"Cook Islands","CK"),
new CountryModel(46,"Chile","CL"),
new CountryModel(47,"Cameroon","CM"),
new CountryModel(48,"China","CN"),
new CountryModel(49,"Colombia","CO"),
new CountryModel(50,"Costa Rica","CR"),
new CountryModel(51,"Cuba","CU"),
new CountryModel(52,"Cape Verde","CV"),
new CountryModel(53,"Curaçao","CW"),
new CountryModel(54,"Christmas Island","CX"),
new CountryModel(55,"Cyprus","CY"),
new CountryModel(56,"Czech Republic","CZ"),
new CountryModel(57,"Germany","DE"),
new CountryModel(58,"Djibouti","DJ"),
new CountryModel(59,"Denmark","DK"),
new CountryModel(60,"Dominica","DM"),
new CountryModel(61,"Dominican Republic","DO"),
new CountryModel(62,"Algeria","DZ"),
new CountryModel(63,"Ecuador","EC"),
new CountryModel(64,"Estonia","EE"),
new CountryModel(65,"Egypt","EG"),
new CountryModel(66,"Western Sahara","EH"),
new CountryModel(67,"Eritrea","ER"),
new CountryModel(68,"Spain","ES"),
new CountryModel(69,"Ethiopia","ET"),
new CountryModel(70,"Finland","FI"),
new CountryModel(71,"Fiji","FJ"),
new CountryModel(72,"Falkland Islands (Malvinas)","FK"),
new CountryModel(73,"Micronesia, Federated States Of","FM"),
new CountryModel(74,"Faroe Islands","FO"),
new CountryModel(75,"France","FR"),
new CountryModel(76,"Gabon","GA"),
new CountryModel(77,"United Kingdom","GB"),
new CountryModel(78,"Grenada","GD"),
new CountryModel(79,"Georgia","GE"),
new CountryModel(80,"French Guiana","GF"),
new CountryModel(81,"Guernsey","GG"),
new CountryModel(82,"Ghana","GH"),
new CountryModel(83,"Gibraltar","GI"),
new CountryModel(84,"Greenland","GL"),
new CountryModel(85,"Gambia","GM"),
new CountryModel(86,"Guinea","GN"),
new CountryModel(87,"Guadeloupe","GP"),
new CountryModel(88,"Equatorial Guinea","GQ"),
new CountryModel(89,"Greece","GR"),
new CountryModel(90,"South Georgia And The South Sandwich Islands","GS"),
new CountryModel(91,"Guatemala","GT"),
new CountryModel(92,"Guam","GU"),
new CountryModel(93,"Guinea-Bissau","GW"),
new CountryModel(94,"Guyana","GY"),
new CountryModel(95,"Hong Kong SAR, China","HK"),
new CountryModel(96,"Heard Island And Mcdonald Islands","HM"),
new CountryModel(97,"Honduras","HN"),
new CountryModel(98,"Croatia","HR"),
new CountryModel(99,"Haiti","HT"),
new CountryModel(100,"Hungary","HU"),
new CountryModel(101,"Indonesia","ID"),
new CountryModel(102,"Ireland","IE"),
new CountryModel(103,"Israel","IL"),
new CountryModel(104,"Isle Of Man","IM"),
new CountryModel(105,"India","IN"),
new CountryModel(107,"Iraq","IQ"),
new CountryModel(108,"Iran, Islamic Republic Of","IR"),
new CountryModel(109,"Iceland","IS"),
new CountryModel(110,"Italy","IT"),
new CountryModel(111,"Jersey","JE"),
new CountryModel(112,"Jamaica","JM"),
new CountryModel(113,"Jordan","JO"),
new CountryModel(114,"Japan","JP"),
new CountryModel(115,"Kenya","KE"),
new CountryModel(116,"Kyrgyzstan","KG"),
new CountryModel(117,"Cambodia","KH"),
new CountryModel(118,"Kiribati","KI"),
new CountryModel(119,"Comoros","KM"),
new CountryModel(120,"Saint Kitts And Nevis","KN"),
new CountryModel(121,"Korea, Democratic People'S Republic Of","KP"),
new CountryModel(122,"Korea, Republic Of","KR"),
new CountryModel(123,"Kuwait","KW"),
new CountryModel(124,"Cayman Islands","KY"),
new CountryModel(125,"Kazakhstan","KZ"),
new CountryModel(126,"Lao People'S Democratic Republic","LA"),
new CountryModel(127,"Lebanon","LB"),
new CountryModel(128,"Saint Lucia","LC"),
new CountryModel(129,"Liechtenstein","LI"),
new CountryModel(130,"Sri Lanka","LK"),
new CountryModel(131,"Liberia","LR"),
new CountryModel(132,"Lesotho","LS"),
new CountryModel(133,"Lithuania","LT"),
new CountryModel(134,"Luxembourg","LU"),
new CountryModel(135,"Latvia","LV"),
new CountryModel(136,"Libya","LY"),
new CountryModel(137,"Morocco","MA"),
new CountryModel(138,"Monaco","MC"),
new CountryModel(139,"Moldova, Republic Of","MD"),
new CountryModel(140,"Montenegro","ME"),
new CountryModel(141,"Saint Martin (French Part)","MF"),
new CountryModel(142,"Madagascar","MG"),
new CountryModel(143,"Marshall Islands","MH"),
new CountryModel(144,"Macedonia, The Former Yugoslav Republic Of","MK"),
new CountryModel(145,"Mali","ML"),
new CountryModel(146,"Myanmar","MM"),
new CountryModel(147,"Mongolia","MN"),
new CountryModel(148,"Macao SAR, China","MO"),
new CountryModel(149,"Northern Mariana Islands","MP"),
new CountryModel(150,"Martinique","MQ"),
new CountryModel(151,"Mauritania","MR"),
new CountryModel(152,"Montserrat","MS"),
new CountryModel(153,"Malta","MT"),
new CountryModel(154,"Mauritius","MU"),
new CountryModel(155,"Maldives","MV"),
new CountryModel(156,"Malawi","MW"),
new CountryModel(157,"Mexico","MX"),
new CountryModel(158,"Malaysia","MY"),
new CountryModel(159,"Mozambique","MZ"),
new CountryModel(160,"Namibia","NA"),
new CountryModel(161,"New Caledonia","NC"),
new CountryModel(162,"Niger","NE"),
new CountryModel(163,"Norfolk Island","NF"),
new CountryModel(164,"Nigeria","NG"),
new CountryModel(165,"Nicaragua","NI"),
new CountryModel(166,"Netherlands","NL"),
new CountryModel(167,"Norway","NO"),
new CountryModel(168,"Nepal","NP"),
new CountryModel(169,"Nauru","NR"),
new CountryModel(170,"Niue","NU"),
new CountryModel(171,"New Zealand","NZ"),
new CountryModel(172,"Oman","OM"),
new CountryModel(173,"Panama","PA"),
new CountryModel(174,"Peru","PE"),
new CountryModel(175,"French Polynesia","PF"),
new CountryModel(176,"Papua New Guinea","PG"),
new CountryModel(177,"Philippines","PH"),
new CountryModel(178,"Pakistan","PK"),
new CountryModel(179,"Poland","PL"),
new CountryModel(180,"Saint Pierre And Miquelon","PM"),
new CountryModel(181,"Pitcairn","PN"),
new CountryModel(182,"Puerto Rico","PR"),
new CountryModel(183,"Palestine, State Of","PS"),
new CountryModel(184,"Portugal","PT"),
new CountryModel(185,"Palau","PW"),
new CountryModel(186,"Paraguay","PY"),
new CountryModel(187,"Qatar","QA"),
new CountryModel(188,"Réunion","RE"),
new CountryModel(189,"Romania","RO"),
new CountryModel(190,"Serbia","RS"),
new CountryModel(191,"Russian Federation","RU"),
new CountryModel(192,"Rwanda","RW"),
new CountryModel(193,"Saudi Arabia","SA"),
new CountryModel(194,"Solomon Islands","SB"),
new CountryModel(195,"Seychelles","SC"),
new CountryModel(196,"Sudan","SD"),
new CountryModel(197,"Sweden","SE"),
new CountryModel(198,"Singapore","SG"),
new CountryModel(199,"Saint Helena, Ascension And Tristan Da Cunha","SH"),
new CountryModel(200,"Slovenia","SI"),
new CountryModel(201,"Svalbard And Jan Mayen","SJ"),
new CountryModel(202,"Slovakia","SK"),
new CountryModel(203,"Sierra Leone","SL"),
new CountryModel(204,"San Marino","SM"),
new CountryModel(205,"Senegal","SN"),
new CountryModel(206,"Somalia","SO"),
new CountryModel(207,"Suriname","SR"),
new CountryModel(208,"Sao Tome And Principe","ST"),
new CountryModel(209,"El Salvador","SV"),
new CountryModel(210,"Sint Maarten (Dutch Part)","SX"),
new CountryModel(211,"Syrian Arab Republic","SY"),
new CountryModel(212,"Swaziland","SZ"),
new CountryModel(213,"Turks And Caicos Islands","TC"),
new CountryModel(214,"Chad","TD"),
new CountryModel(215,"French Southern Territories","TF"),
new CountryModel(216,"Togo","TG"),
new CountryModel(217,"Thailand","TH"),
new CountryModel(218,"Tajikistan","TJ"),
new CountryModel(219,"Tokelau","TK"),
new CountryModel(220,"Timor-Leste","TL"),
new CountryModel(221,"Turkmenistan","TM"),
new CountryModel(222,"Tunisia","TN"),
new CountryModel(223,"Tonga","TO"),
new CountryModel(224,"Turkey","TR"),
new CountryModel(225,"Trinidad And Tobago","TT"),
new CountryModel(226,"Tuvalu","TV"),
new CountryModel(227,"Taiwan, ROC","TW"),
new CountryModel(228,"Tanzania, United Republic Of","TZ"),
new CountryModel(229,"Ukraine","UA"),
new CountryModel(230,"Uganda","UG"),
new CountryModel(231,"United States Minor Outlying Islands","UM"),
new CountryModel(232,"United States","US"),
new CountryModel(233,"Uruguay","UY"),
new CountryModel(234,"Uzbekistan","UZ"),
new CountryModel(235,"Holy See (Vatican City State)","VA"),
new CountryModel(236,"Saint Vincent And The Grenadines","VC"),
new CountryModel(237,"Venezuela, Bolivarian Republic Of","VE"),
new CountryModel(238,"Virgin Islands, British","VG"),
new CountryModel(239,"Virgin Islands, U.S.","VI"),
new CountryModel(240,"Vietnam","VN"),
new CountryModel(241,"Vanuatu","VU"),
new CountryModel(242,"Wallis And Futuna","WF"),
new CountryModel(243,"Samoa","WS"),
new CountryModel(244,"Kosovo","XK"),
new CountryModel(245,"Yemen","YE"),
new CountryModel(246,"Mayotte","YT"),
new CountryModel(247,"South Africa","ZA"),
new CountryModel(248,"Zambia","ZM"),
new CountryModel(249,"Zimbabwe","ZW"),
new CountryModel(253,"Netherlands Antilles","AN"),
new CountryModel(254,"South Sudan","SS"),
new CountryModel(255,"Serbia And Montenegro","CS"),
new CountryModel(256,"British Indian Ocean Territory","IO"),
new CountryModel(257,"Andorra","AD")
        };
    }
}