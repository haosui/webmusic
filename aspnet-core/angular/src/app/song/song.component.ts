import { Component, OnInit } from '@angular/core';
import { SongDto, SongService } from '@proxy/songs';
import { ListService, PagedResultDto } from '@abp/ng.core';
import { stringify } from 'querystring';
import { TagDto, TagService } from '@proxy/tags';
import { Subscriber } from 'rxjs';
import { ReportDto } from '@proxy/reports';
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
  tags: TagDto[];
  comments: ReportDto[];
  constructor(public readonly list: ListService, private songService: SongService, private taggService: TagService) {

   }

  ngOnInit(): void {
     
     this.songService.listSongByLimitfrom(0).subscribe(r => {
       this.songs = r;
       console.log('soong',this.songs);
     });
     
    this.taggService.getlisttag().subscribe(r=> {
      console.log(r);
      this.tags = r;
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
    this.songService.gelistreportByIdsong(item.id).subscribe(r =>{
      this.comments = r;
    });
  }

  ssearch(text: string)
  {
    console.log(text,"DD");
    this.songService.sOngSearchbynameByKeyAndLimitfrom(text,0).subscribe( r =>{
      this.songs = r;
      console.log('search',this.songs);
    });
  }

  ssearchtacgia(event: any)
  {

    //console.log(event.target.value,"DD");
    this.songService.songlistByAuthorByAuthotAndLimitfrom(event.target.value, 0).subscribe(r=>
      {
        
        this.songs = r;
      });
  }
  ssearchcasi(event: any)
  {

    
    this.songService.songListBySingerByTextAndLimitfrom(event.target.value, 0).subscribe(r=>
      {
        console.log(r);
        this.songs = r;
      });
  }
  searchbytag(item: any)
  {
    this.songService.searchbyTagByTaggAndLimitfrom(item.id, 0).subscribe(r =>
      {
        this.songs = r;
      });
  }

  top10(){
    this.songService.chartByLimitfrom(0).subscribe( r=> {
      this.songs = r;
    })
  }
}
