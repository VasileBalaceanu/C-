// Creator: k6 Browser Recorder 0.5.3

import { sleep, group, check } from "k6";
import http from "k6/http";
import {Trend, Rate} from "k6/metrics";

let response;
let myTrend = new Trend("response_time");
const myFailRate = new Rate("failed_requests");

export const options = { 
 vus: 10,
 duration: "10s",
 thresholds :{
	"response_time":["p(100) <  500"],
	"failed_requests": ["rate < 0.1"]
}
};
export default function main() {
  

  group(
    "page_1 - https://www.badabum.ro/shopping/checkout/?do_checkout=true#checkout-wrapper",
    function () {
      response = http.get(
        "https://www.badabum.ro/ajax/checkout/cfcid?new_firstname=&new_lastname=&new_telephone=&new_email=&errmsg=(Va%20rugam%20selectati%20una%20dintre%20optiunile%20de%20livrare%20de%20mai%20jos)|(Completati%20corect%20si%20complet%20campurile%20de%20client%20nou%20marcate%20cu%20rosu)|(Pentru%20a%20trimite%20comanda%20trebuie%20sa%20fiti%20de%20acord%20cu%20conditiile%20de%20utilizare)|",
        {
          headers: {
            accept: "*/*",
            "accept-encoding": "gzip, deflate, br",
            "accept-language": "ro-RO,ro;q=0.9,en-US;q=0.8,en;q=0.7",
            "sec-fetch-dest": "empty",
            "sec-fetch-mode": "cors",
            "sec-fetch-site": "same-origin",
            "x-requested-with": "XMLHttpRequest",
          },
        }
      );
		check(response, {"Response has status 200":(response) => response.status === 200});
		console.log("Response time was " + String(response.timings.duration) + " ms");
		myFailRate.add(response.status !== 200);
		myTrend.add(response.timings.duration);
    }
  );

  // Automatically added sleep
  sleep(1);
}