import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { finalize } from 'rxjs/operators'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  REST_API_SERVER = "http://localhost:44388/message/EncryptMessage";
  msg = '';
  title = 'msgenc-front';
  messages = [];
  isLoading = false;

  constructor(private httpClient: HttpClient) { }

  onSendMessage() {

    if (this.msg.length > 0) {
      this.isLoading = true;
      this.sendPostRequest(this.msg)
        .pipe(finalize(() => this.isLoading = false))
        .subscribe((resp: any) => {
          if (resp.error) {
            alert(resp.error);
          }
          else {
            this.messages.push(resp.data);
            this.msg = '';
          }
        })
    } else {
      alert("Пустое сообщение")
    }
  }

  sendPostRequest(msg) {
    return this.httpClient.post(this.REST_API_SERVER, { Text: msg });
  }
}
