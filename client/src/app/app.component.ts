import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AppUser } from './AppUser';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  http = inject(HttpClient);
  title = 'Dating App';

  public UserName!: string;

  public UserId!: number;

  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/users').subscribe((item : AppUser | any) =>  { this.UserName = item.UserName, this.UserId = item.Id} );
  }
}
