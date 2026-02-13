import 'package:json_annotation/json_annotation.dart';

part 'user_activity.g.dart';

@JsonSerializable()
class UserActivity {
  final int id;
  final User? user;
  final ActivityBrojIndeksa? activityBrojIndeksa;
  final DateTime? assignedDate;
  final String status;
  final String note;
  final DateTime? completedAt;
  final String rewardTitle;
  final DateTime? rewardedAt;
  final int numberOfPoints;

  UserActivity({
    this.id = 0,
    this.user,
    this.activityBrojIndeksa,
    this.assignedDate,
    this.status = "",
    this.note = "",
    this.completedAt,
    this.rewardTitle = "",
    this.rewardedAt,
    this.numberOfPoints = 0,
  });

  factory UserActivity.fromJson(Map<String, dynamic> json) =>
      _$UserActivityFromJson(json);

  Map<String, dynamic> toJson() => _$UserActivityToJson(this);
}

@JsonSerializable()
class User {
  final int id;
  final String firstName;
  final String lastName;

  User({
    this.id = 0,
    this.firstName = '',
    this.lastName = '',
  });

  factory User.fromJson(Map<String, dynamic> json) => _$UserFromJson(json);

  Map<String, dynamic> toJson() => _$UserToJson(this);
}

@JsonSerializable()
class ActivityBrojIndeksa {
  final int id;
  final String name;
  final String description;
  final DateTime? dueDate;

  ActivityBrojIndeksa(
      {this.id = 0, this.name = '', this.description = '', this.dueDate});

  factory ActivityBrojIndeksa.fromJson(Map<String, dynamic> json) =>
      _$ActivityBrojIndeksaFromJson(json);

  Map<String, dynamic> toJson() => _$ActivityBrojIndeksaToJson(this);
}
