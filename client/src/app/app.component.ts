import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrl: './app.component.css', 
  imports: [
    FormsModule,
    // NgFor
]
})
export class AppComponent implements OnInit {
  http = inject(HttpClient);
  title = 'Hozepha DA';
  Users: any;

  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/users')
             .subscribe({
              next: response => this.Users = response,
              error: error => console.log(error),
              complete: () => console.log("the request has completed")
             });
  }
}
