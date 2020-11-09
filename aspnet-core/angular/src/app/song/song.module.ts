import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatGridListModule} from '@angular/material/grid-list';
import {MatCardModule} from '@angular/material/card';
import {MatButtonModule} from '@angular/material/button';
import { SongRoutingModule } from './song-routing.module';
import { SongComponent } from './song.component';


@NgModule({
  declarations: [SongComponent],
  imports: [
    CommonModule,
    SongRoutingModule,
    MatGridListModule,
    MatCardModule,
    MatButtonModule
  ]
})
export class SongModule { }
