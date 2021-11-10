import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-create-technical-skill',
  templateUrl: './create-technical-skill.component.html',
  styleUrls: ['./create-technical-skill.component.css']
})
export class CreateTechnicalSkillComponent implements OnInit {

  roundInformation = [
    {RoundInformationId : 1, RoundName : "Profile Screening"},
    {RoundInformationId : 2, RoundName : "Initial Telephonic Interview"},
    {RoundInformationId : 3, RoundName : "Technical Telephonic Interview"},
    {RoundInformationId : 4, RoundName : "Technical System Test"},
    {RoundInformationId : 5, RoundName : "Technical Face To Face Interview"},
    {RoundInformationId : 6, RoundName : "Final Face To Face Interview"}
  ];

  Rating = [
    {RatingId : 1, RatingValue : "Below Satisfactory"},
    {RatingId : 2, RatingValue : "Satisfactory"},
    {RatingId : 3, RatingValue : "Good"},
    {RatingId : 4, RatingValue : "Very Good"},
    {RatingId : 5, RatingValue : "Excellent"}
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
