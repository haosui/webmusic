import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateLyricDto {
  lyric: string;
  songId: string;
}

export interface CreateUpdateSongDto {
  name: string;
  authorId: string;
  albumId: string;
  singerId: string;
  songpath: string;
  imagepath: string;
}

export interface LyricDto extends AuditedEntityDto<string> {
  lyric: string;
  songId: string;
}

export interface SongDto extends AuditedEntityDto<string> {
  name: string;
  authorId: string;
  albumId: string;
  authorname: string;
  singername: string;
  singerId: string;
  imagepath: string;
  songpath: string;
}
