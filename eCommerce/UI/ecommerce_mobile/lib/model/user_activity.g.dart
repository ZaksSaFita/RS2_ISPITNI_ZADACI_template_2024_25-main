// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'user_activity.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

UserActivity _$UserActivityFromJson(Map<String, dynamic> json) => UserActivity(
      id: (json['id'] as num?)?.toInt() ?? 0,
      user: json['user'] == null
          ? null
          : User.fromJson(json['user'] as Map<String, dynamic>),
      activityBrojIndeksa: json['activityBrojIndeksa'] == null
          ? null
          : ActivityBrojIndeksa.fromJson(
              json['activityBrojIndeksa'] as Map<String, dynamic>),
      assignedDate: json['assignedDate'] == null
          ? null
          : DateTime.parse(json['assignedDate'] as String),
      status: json['status'] as String? ?? "",
      note: json['note'] as String? ?? "",
      completedAt: json['completedAt'] == null
          ? null
          : DateTime.parse(json['completedAt'] as String),
      rewardTitle: json['rewardTitle'] as String? ?? "",
      rewardedAt: json['rewardedAt'] == null
          ? null
          : DateTime.parse(json['rewardedAt'] as String),
      numberOfPoints: (json['numberOfPoints'] as num?)?.toInt() ?? 0,
    );

Map<String, dynamic> _$UserActivityToJson(UserActivity instance) =>
    <String, dynamic>{
      'id': instance.id,
      'user': instance.user,
      'activityBrojIndeksa': instance.activityBrojIndeksa,
      'assignedDate': instance.assignedDate?.toIso8601String(),
      'status': instance.status,
      'note': instance.note,
      'completedAt': instance.completedAt?.toIso8601String(),
      'rewardTitle': instance.rewardTitle,
      'rewardedAt': instance.rewardedAt?.toIso8601String(),
      'numberOfPoints': instance.numberOfPoints,
    };

User _$UserFromJson(Map<String, dynamic> json) => User(
      id: (json['id'] as num?)?.toInt() ?? 0,
      firstName: json['firstName'] as String? ?? '',
      lastName: json['lastName'] as String? ?? '',
    );

Map<String, dynamic> _$UserToJson(User instance) => <String, dynamic>{
      'id': instance.id,
      'firstName': instance.firstName,
      'lastName': instance.lastName,
    };

ActivityBrojIndeksa _$ActivityBrojIndeksaFromJson(Map<String, dynamic> json) =>
    ActivityBrojIndeksa(
      id: (json['id'] as num?)?.toInt() ?? 0,
      name: json['name'] as String? ?? '',
      description: json['description'] as String? ?? '',
      dueDate: json['dueDate'] == null
          ? null
          : DateTime.parse(json['dueDate'] as String),
    );

Map<String, dynamic> _$ActivityBrojIndeksaToJson(
        ActivityBrojIndeksa instance) =>
    <String, dynamic>{
      'id': instance.id,
      'name': instance.name,
      'description': instance.description,
      'dueDate': instance.dueDate?.toIso8601String(),
    };
