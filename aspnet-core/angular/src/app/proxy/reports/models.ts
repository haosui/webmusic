import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateReportDto {
  date: string;
  songId: string;
  userId: string;
  content: string;
  score: number;
}

export interface ReportDto extends AuditedEntityDto<string> {
  date: string;
  songId: string;
  userId: string;
  username: string;
  content: string;
  score: number;
}
