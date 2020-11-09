import { Component, OnInit } from '@angular/core';
import { SongDto, SongService } from '@proxy/songs';
import { ListService, PagedResultDto } from '@abp/ng.core';
@Component({
  selector: 'app-song',
  templateUrl: './song.component.html',
  styleUrls: ['./song.component.scss'],
  providers: [ListService],
})
export class SongComponent implements OnInit {
  songs : SongDto[];
  imgsrc: string ="";
  musicsrc :string ="";
  info : string = "";
  constructor(public readonly list: ListService, private songService: SongService) {

   }

  ngOnInit(): void {
     
     this.songService.listSongByLimitfrom(0).subscribe(r => {
       this.songs = r;
       console.log('soong',this.songs);
     });
    
     
  }
  Playy(item)
  {
    this.imgsrc = item.imagepath;
    this.musicsrc = item.songpath;
    this.info = item.name + "--"+item.singername;
    var audioo  =  <HTMLAudioElement>document.getElementById("playaudio");
    audioo.src= this.musicsrc;
    audioo.load();
    audioo.play();
  }

  ssearch(text: string)
  {
    console.log(text);
    this.songService.sOngSearchbynameByKeyAndLimitfrom(text,0).subscribe( r =>{
      this.songs = r;
      console.log('search',this.songs);
    });
  }

}
