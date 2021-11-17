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
	"response_time":["p(100) <  230"],
	"failed_requests": ["rate < 0.1"]
}
};

export default function main() {
  let response;

  group("page_2 - https://test.k6.io/contacts.php", function () {
    response = http.get("https://test.k6.io/contacts.php", {
      headers: {
        accept:
          "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9",
        "accept-encoding": "gzip, deflate, br",
        "accept-language": "ro-RO,ro;q=0.9,en-US;q=0.8,en;q=0.7",
        connection: "keep-alive",
        host: "test.k6.io",
        "sec-fetch-dest": "document",
        "sec-fetch-mode": "navigate",
        "sec-fetch-site": "same-origin",
        "sec-fetch-user": "?1",
        "upgrade-insecure-requests": "1",
      },
    });
	check(response, {"Response has status 200":(response) => response.status === 200});
		console.log("Response time was " + String(response.timings.duration) + " ms");
		myFailRate.add(response.status !== 200);
		myTrend.add(response.timings.duration);
  });

  // Automatically added sleep
  sleep(1);
}